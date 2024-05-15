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
    public class InternService
    {
        public static void Create(InternDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InternDTO, Intern>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Intern>(c);
            DataAccessFactory.InternData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<InternDTO> Show()
        {
            var data = DataAccessFactory.InternData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Intern, InternDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<InternDTO>>(data);
            return mapped;
        }

        public static InternDTO Show(int id)
        {
            var data = DataAccessFactory.InternData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Intern, InternDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<InternDTO>(data);
            return mapped;
        }


        public static bool Update(InternDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<InternDTO, Intern>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Intern>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.InternData().Update(student);
            return success;
        }
    }
}
