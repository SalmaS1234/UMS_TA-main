﻿using AutoMapper;
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
    public class SubmissionService
    {
        public static void Create(SubmissionDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SubmissionDTO, Submission>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Submission>(c);
            DataAccessFactory.SubmissionData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<SubmissionDTO> Show()
        {
            var data = DataAccessFactory.SubmissionData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Submission, SubmissionDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SubmissionDTO>>(data);
            return mapped;
        }

        public static SubmissionDTO Show(int id)
        {
            var data = DataAccessFactory.SubmissionData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Submission, SubmissionDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SubmissionDTO>(data);
            return mapped;
        }


        public static bool Update(SubmissionDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SubmissionDTO, Submission>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Submission>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.SubmissionData().Update(student);
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
