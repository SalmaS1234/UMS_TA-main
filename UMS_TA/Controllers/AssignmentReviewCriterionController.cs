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
    public class AssignmentReviewCriterionController : ApiController
    {
        [HttpPost]
        [Route("api/AssignmentReviewCriterion/Create")]
        public HttpResponseMessage Create(AssignmentReviewCriterionDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "AssignmentReviewCriteriondto cannot be null");
            }

            try
            {
                AssignmentReviewCriterionService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register AssignmentReviewCriterion: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/AssignmentReviewCriterion/Show")]
        public HttpResponseMessage Show()
        {
            var data = AssignmentReviewCriterionService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/AssignmentReviewCriterion/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = AssignmentReviewCriterionService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/AssignmentReviewCriterion/Update")]
        public HttpResponseMessage Update(AssignmentReviewCriterionDTO studentDTO)
        {
            try
            {
                var success = AssignmentReviewCriterionService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "AssignmentReviewCriterion updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "AssignmentReviewCriterion not found or update failed.");
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
