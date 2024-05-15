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
    public class TeacherController : ApiController
    {
        [HttpPost]
        [Route("api/Teacher/Create")]
        public HttpResponseMessage Create(TeacherDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Teacherdto cannot be null");
            }

            try
            {
                TeacherService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register Teacher: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Teacher/Show")]
        public HttpResponseMessage Show()
        {
            var data = TeacherService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Teacher/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = TeacherService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Teacher/Update")]
        public HttpResponseMessage Update(TeacherDTO studentDTO)
        {
            try
            {
                var success = TeacherService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Teacher updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Teacher not found or update failed.");
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



        [HttpGet]
        [Route("api/Teacher/{id}/Courses")]
        public HttpResponseMessage TeacherCourse(int id)
        {
            try
            {
                var data = TeacherService.ShowTeacherCourses(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }



        [HttpGet]
        [Route("api/Teacher/{id}/Reviews")]
        public HttpResponseMessage TeacherReview(int id)
        {
            try
            {
                var data = TeacherService.ShowTeacherReview(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }
    }
}
