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
    public class ResourceService
    {
        public static void Create(ResourceDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ResourceDTO, Resource>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Resource>(c);
            DataAccessFactory.ResourceData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<ResourceDTO> Show()
        {
            var data = DataAccessFactory.ResourceData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Resource, ResourceDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ResourceDTO>>(data);
            return mapped;
        }

        public static ResourceDTO Show(int id)
        {
            var data = DataAccessFactory.ResourceData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Resource, ResourceDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ResourceDTO>(data);
            return mapped;
        }


        public static bool Update(ResourceDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ResourceDTO, Resource>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Resource>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.ResourceData().Update(student);
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
