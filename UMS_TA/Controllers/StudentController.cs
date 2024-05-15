using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace UMS_TA.Controllers
{
    public class StudentController : ApiController
    {
        [HttpPost]
        [Route("api/Student/Create")]
        public HttpResponseMessage Create(StudentDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "studentdto cannot be null");
            }

            try
            {
                StudentService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register student: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Student/Show")]
        public HttpResponseMessage Show()
        {
            var data = StudentService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Student/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = StudentService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Student/Update")]
        public HttpResponseMessage Update(StudentDTO studentDTO)
        {
            try
            {
                var success = StudentService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Student updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found or update failed.");
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
        [Route("api/Student/{ids}")]
        public HttpResponseMessage Student(int id)
        {
            try
            {
                var data = StudentService.Show(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }





        [HttpGet]
        [Route("api/Student/{id}/Courses")]
        public HttpResponseMessage StudentCourses(int id)
        {
            try
            {
                var data = StudentService.ShowwithCourses(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,new {Message = ex.Message});
            }
            
            
        }

        [HttpGet]
        [Route("api/Student/{id}/FeedAndServy")]
        public HttpResponseMessage StudentFeedServy(int id)
        {
            try
            {
                var data = StudentService.ShowWithFeed_Servy(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }




        [HttpGet]
        [Route("api/Student/{id}/Assignment")]
        public HttpResponseMessage StudentAssisgnment(int id)
        {
            try
            {
                var data = StudentService.ShowStudentAndAssignment(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }


        [HttpGet]
        [Route("api/Student/{id}/Review")]
        public HttpResponseMessage StudentReview(int id)
        {
            try
            {
                var data = StudentService.ShowStudentAndReviews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }


        [HttpGet]
        [Route("api/Student/{id}/Submission")]
        public HttpResponseMessage StudentSubmission(int id)
        {
            try
            {
                var data = StudentService.ShowStudentAndSubmission(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }


        [HttpGet]
        [Route("api/Student/{id}/StudentCourseAssisgnmentSubmissionReviewConvocationInternComapany")]
        public HttpResponseMessage STUStudentCourseAssisgnmentSubmissionReviewConvocationInternComapany_(int id)
        {
            try
            {
                var data = StudentService.ShowStudentCourseAssisgnmentSubmissionReviewConvocationInternComapany(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }



    }
}
