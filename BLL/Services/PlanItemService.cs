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
    public class PlanItemService
    {

        public static void Create(PlanItemDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanItemDTO, PlanItem>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<PlanItem>(c);
            DataAccessFactory.PlanItemData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<PlanItemDTO> Show()
        {
            var data = DataAccessFactory.PlanItemData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PlanItem, PlanItemDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PlanItemDTO>>(data);
            return mapped;
        }

        public static PlanItemDTO Show(int id)
        {
            var data = DataAccessFactory.PlanItemData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlanItem, PlanItemDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PlanItemDTO>(data);
            return mapped;
        }


        public static bool Update(PlanItemDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PlanItemDTO, PlanItem>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<PlanItem>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.PlanItemData().Update(student);
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
