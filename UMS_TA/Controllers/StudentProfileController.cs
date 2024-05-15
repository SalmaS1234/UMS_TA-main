using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UMS_TA.Controllers
{
    public class StudentProfileController : ApiController
    {
        [HttpPost]
        [Route("api/StudentProfile/Create")]
        public HttpResponseMessage Create(StudentProfileDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "StudentProfileDTO cannot be null");
            }

            try
            {
                StudentProfileService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register StudentProfile: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/StudentProfile/Show")]
        public HttpResponseMessage Show()
        {
            var data = StudentProfileService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/StudentProfile/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = StudentProfileService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/StudentProfile/Update")]
        public HttpResponseMessage Update(StudentProfileDTO studentDTO)
        {
            try
            {
                var success = StudentProfileService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "StudentProfile updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "StudentProfile not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
        /*
                [HttpDelete]
                [Route("api/Student/Delete/{id}")]
                public HttpResponseMessage Delete(int id)
                {
                    try
                    {
                        var success = StudentService.Delete(id);
                        if (success)
                        {
                            return Request.CreateResponse(HttpStatusCode.OK, "Student deleted successfully.");
                        }
                        else
                        {
                            return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found or delete failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
                    }
                }*/
    }
}
