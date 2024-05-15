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
    public class CompanyService
    {
        public static void Create(CompanyDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CompanyDTO, Company>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Company>(c);
            DataAccessFactory.CompanyData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<CompanyDTO> Show()
        {
            var data = DataAccessFactory.CompanyData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Company, CompanyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CompanyDTO>>(data);
            return mapped;
        }

        public static CompanyDTO Show(int id)
        {
            var data = DataAccessFactory.CompanyData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Company, CompanyDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CompanyDTO>(data);
            return mapped;
        }


        public static bool Update(CompanyDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CompanyDTO, Company>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Company>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.CompanyData().Update(student);
            return success;
        }
    }
}
