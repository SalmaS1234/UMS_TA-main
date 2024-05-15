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
    public class TeacherService
    {

        public static void Create(TeacherDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Teacher>(c);
            DataAccessFactory.TeacherData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<TeacherDTO> Show()
        {
            var data = DataAccessFactory.TeacherData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TeacherDTO>>(data);
            return mapped;
        }

        public static TeacherDTO Show(int id)
        {
            var data = DataAccessFactory.TeacherData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherDTO>(data);
            return mapped;
        }


        public static bool Update(TeacherDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Teacher>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.TeacherData().Update(student);
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


        public static TeacherCourseDTO ShowTeacherCourses(int id)
        {
            var data = DataAccessFactory.TeacherData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherCourseDTO>();
                c.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherCourseDTO>(data);
            return mapped;
        }

        public static TeacherReviewDTO ShowTeacherReview(int id)
        {
            var data = DataAccessFactory.TeacherData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherReviewDTO>();
                c.CreateMap<Review, ReviewDTO>();
                c.CreateMap<Submission, SubmissionDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TeacherReviewDTO>(data);
            return mapped;
        }
    }
}
