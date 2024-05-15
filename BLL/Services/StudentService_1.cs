using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService_1
    {
        public static void Create(StudentDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Student>(c);
            DataAccessFactory.StudentData1().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<StudentDTO> Show()
        {
            var data = DataAccessFactory.StudentData1().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StudentDTO>>(data);
            return mapped;
        }

        public static StudentDTO Show(int id)
        {
            var data = DataAccessFactory.StudentData1().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StudentDTO>(data);
            return mapped;
        }


        public static Student Update(StudentDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Student>(studentDTO);
            // Call the data access layer to update the student
            var success = DataAccessFactory.StudentData1().Update(student);
            return success;
        }
    }
}
