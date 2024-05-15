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
    public class AlumniService
    {
        public static void Create(AlumniDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AlumniDTO, Alumni>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Alumni>(c);
            DataAccessFactory.AlumniData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<AlumniDTO> Show()
        {
            var data = DataAccessFactory.AlumniData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Alumni, AlumniDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AlumniDTO>>(data);
            return mapped;
        }

        public static AlumniDTO Show(int id)
        {
            var data = DataAccessFactory.AlumniData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Alumni, AlumniDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AlumniDTO>(data);
            return mapped;
        }


        public static bool Update(AlumniDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AlumniDTO, Alumni>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Alumni>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.AlumniData().Update(student);
            return success;
        }
    }
}
