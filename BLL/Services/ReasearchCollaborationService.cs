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
    public class ReasearchCollaborationService
    {
        public static void Create(ReasearchCollaborationDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReasearchCollaborationDTO, ReasearchCollaboration>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<ReasearchCollaboration>(c);
            DataAccessFactory.ReasearchCollaborationData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<ReasearchCollaborationDTO> Show()
        {
            var data = DataAccessFactory.ReasearchCollaborationData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ReasearchCollaboration, ReasearchCollaborationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReasearchCollaborationDTO>>(data);
            return mapped;
        }

        public static ReasearchCollaborationDTO Show(int id)
        {
            var data = DataAccessFactory.ReasearchCollaborationData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReasearchCollaboration, ReasearchCollaborationDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReasearchCollaborationDTO>(data);
            return mapped;
        }


        public static bool Update(ReasearchCollaborationDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ReasearchCollaborationDTO, ReasearchCollaboration>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<ReasearchCollaboration>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.ReasearchCollaborationData().Update(student);
            return success;
        }
    }
}
