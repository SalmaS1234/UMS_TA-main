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
    public class ConvocationRequestSerrvice
    {
        public static void Create(ConvocationRequestDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ConvocationRequestDTO, ConvocationRequest>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<ConvocationRequest>(c);
            DataAccessFactory.ConvocationRequestData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<ConvocationRequestDTO> Show()
        {
            var data = DataAccessFactory.ConvocationRequestData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ConvocationRequest, ConvocationRequestDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ConvocationRequestDTO>>(data);
            return mapped;
        }

        public static ConvocationRequestDTO Show(int id)
        {
            var data = DataAccessFactory.ConvocationRequestData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ConvocationRequest, ConvocationRequestDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ConvocationRequestDTO>(data);
            return mapped;
        }


        public static bool Update(ConvocationRequestDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ConvocationRequestDTO, ConvocationRequest>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<ConvocationRequest>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.ConvocationRequestData().Update(student);
            return success;
        }
        /*
                public static bool Delete(int id)
                {
                    try
                    {
                        // Call the data access layer to get the student entity by id
                        var student = DataAccessFactory.StudentData().Show(id);

                        // If student exists, delete it
                        if (student != null)
                        {
                            // Configure AutoMapper to map Student to StudentDTO
                            var config = new MapperConfiguration(cfg =>
                            {
                                cfg.CreateMap<Student, StudentDTO>();
                            });

                            var mapper = new Mapper(config);
                            var studentDTO = mapper.Map<StudentDTO>(student);

                            // Call the data access layer to delete the student
                            var success = DataAccessFactory.StudentData().Delete(studentDTO);
                            return success;
                        }
                        else
                        {
                            // Student not found
                            Console.WriteLine("Student not found.");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log any exceptions
                        Console.WriteLine($"An error occurred while deleting student: {ex.Message}");
                        return false;
                    }
                }

        */
    }
}
