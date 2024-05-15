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
    public class PaperPublishService
    {
        public static void Create(PaperPublishListDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PaperPublishListDTO, PaperPublishList>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<PaperPublishList>(c);
            DataAccessFactory.PaperPublishListData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<PaperPublishListDTO> Show()
        {
            var data = DataAccessFactory.PaperPublishListData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<PaperPublishList, PaperPublishListDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PaperPublishListDTO>>(data);
            return mapped;
        }

        public static PaperPublishListDTO Show(int id)
        {
            var data = DataAccessFactory.PaperPublishListData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaperPublishList, PaperPublishListDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PaperPublishListDTO>(data);
            return mapped;
        }


        public static bool Update(PaperPublishListDTO paperpublishDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaperPublishListDTO, PaperPublishList>();
            });
            var mapper = new Mapper(cfg);
            var paperpublish = mapper.Map<PaperPublishList>(paperpublishDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.PaperPublishListData().Update(paperpublish);
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
