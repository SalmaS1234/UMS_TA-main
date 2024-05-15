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
    public class MentorshipService
    {
        public static void Create(MentorshipDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MentorshipDTO, Mentorship>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Mentorship>(c);
            DataAccessFactory.MentorshipData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<MentorshipDTO> Show()
        {
            var data = DataAccessFactory.MentorshipData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Mentorship, MentorshipDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MentorshipDTO>>(data);
            return mapped;
        }

        public static MentorshipDTO Show(int id)
        {
            var data = DataAccessFactory.MentorshipData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Mentorship, MentorshipDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MentorshipDTO>(data);
            return mapped;
        }


        public static bool Update(MentorshipDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MentorshipDTO, Mentorship>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Mentorship>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.MentorshipData().Update(student);
            return success;
        }
    }
}
