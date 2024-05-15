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
    public class CareerInsightsService
    {
        public static void Create(CareerInsightsDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CareerInsightsDTO, CareerInsights>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<CareerInsights>(c);
            DataAccessFactory.CareerInsightsData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<CareerInsightsDTO> Show()
        {
            var data = DataAccessFactory.CareerInsightsData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<CareerInsights, CareerInsightsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CareerInsightsDTO>>(data);
            return mapped;
        }

        public static CareerInsightsDTO Show(int id)
        {
            var data = DataAccessFactory.CareerInsightsData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CareerInsights, CareerInsightsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CareerInsightsDTO>(data);
            return mapped;
        }


        public static bool Update(CareerInsightsDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CareerInsightsDTO, CareerInsights>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<CareerInsights>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.CareerInsightsData().Update(student);
            return success;
        }
    }
}
