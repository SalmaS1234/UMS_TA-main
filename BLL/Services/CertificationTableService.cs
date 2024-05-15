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
    public class CertificationTableService
    {
        public static void Create(CertificationTableDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CertificationTableDTO, CertificationTable>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<CertificationTable>(c);
            DataAccessFactory.CertificationTableData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<CertificationTableDTO> Show()
        {
            var data = DataAccessFactory.CertificationTableData().Show();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<CertificationTable, CertificationTableDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<CertificationTableDTO>>(data);
            return mapped;
        }

        public static CertificationTableDTO Show(int id)
        {
            var data = DataAccessFactory.CertificationTableData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CertificationTable, CertificationTableDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map< CertificationTableDTO>(data);
            return mapped;
        }


        public static bool Update(CertificationTableDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<CertificationTableDTO, CertificationTable>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<CertificationTable>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.CertificationTableData().Update(student);
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
