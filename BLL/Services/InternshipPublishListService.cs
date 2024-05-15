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
    public class InternshipPublishListService
    {
        public static void Create(InternshipPublishListDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InternshipPublishListDTO, InternshipPublishList>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<InternshipPublishList>(c);
            DataAccessFactory.InternshipPublishListData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<InternshipPublishListDTO> Show()
        {
            var data = DataAccessFactory.InternshipPublishListData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<InternshipPublishList, InternshipPublishListDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<InternshipPublishListDTO>>(data);
            return mapped;
        }

        public static InternshipPublishListDTO Show(int id)
        {
            var data = DataAccessFactory.InternshipPublishListData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<InternshipPublishList, InternshipPublishListDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<InternshipPublishListDTO>(data);
            return mapped;
        }


        public static bool Update(InternshipPublishListDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<InternshipPublishListDTO, InternshipPublishList>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<InternshipPublishList>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.InternshipPublishListData().Update(student);
            return success;
        }
    }
}
