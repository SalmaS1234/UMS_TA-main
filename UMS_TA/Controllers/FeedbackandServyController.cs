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
    public class FeedbackandServyController : ApiController
    {
        [HttpPost]
        [Route("api/FeedbackAndServy/Create")]
        public HttpResponseMessage Create(FeedandSurveryDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "FeedbackAndServydto cannot be null");
            }

            try
            {
                FeedbackandServyService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register FeedbackAndServy: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/FeedbackAndServy/Show")]
        public HttpResponseMessage Show()
        {
            var data = FeedbackandServyService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/FeedbackAndServy/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = FeedbackandServyService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/FeedbackAndServy/Update")]
        public HttpResponseMessage Update(FeedandSurveryDTO FeedbackAndServydto)
        {
            try
            {
                var success = FeedbackandServyService.Update(FeedbackAndServydto);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "FeedbackAndServy updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "FeedbackAndServy not found or update failed.");
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
