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
    public class AddRequestPaperPublishService
    {
        public static void Create(AddRequestPaperPublishDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AddRequestPaperPublishDTO, AddRequestPaperPublish>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<AddRequestPaperPublish>(c);
            DataAccessFactory.AddRequestPaperPublishData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<AddRequestPaperPublishDTO> Show()
        {
            var data = DataAccessFactory.AddRequestPaperPublishData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AddRequestPaperPublish, AddRequestPaperPublishDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AddRequestPaperPublishDTO>>(data);
            return mapped;
        }

        public static AddRequestPaperPublishDTO Show(int id)
        {
            var data = DataAccessFactory.AddRequestPaperPublishData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddRequestPaperPublish, AddRequestPaperPublishDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AddRequestPaperPublishDTO>(data);
            return mapped;
        }


        public static bool Update(AddRequestPaperPublishDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddRequestPaperPublishDTO, AddRequestPaperPublish>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<AddRequestPaperPublish>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.AddRequestPaperPublishData().Update(student);
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
