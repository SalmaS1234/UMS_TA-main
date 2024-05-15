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
    public class ReviewCriterionController : ApiController
    {
        [HttpPost]
        [Route("api/ReviewCriterion/Create")]
        public HttpResponseMessage Create(ReviewCriterionDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ReviewCriteriondto cannot be null");
            }

            try
            {
                ReviewCriterionService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register ReviewCriterion: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/ReviewCriterion/Show")]
        public HttpResponseMessage Show()
        {
            var data = ReviewCriterionService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/ReviewCriterion/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = ReviewCriterionService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/ReviewCriterion/Update")]
        public HttpResponseMessage Update(ReviewCriterionDTO studentDTO)
        {
            try
            {
                var success = ReviewCriterionService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "ReviewCriterion updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "ReviewCriterion not found or update failed.");
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
