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
    public class MentorshipController : ApiController
    {
        [HttpPost]
        [Route("api/Mentorship/Create")]
        public HttpResponseMessage Create(MentorshipDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Mentorshipdto cannot be null");
            }

            try
            {
                MentorshipService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register Mentorship: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Mentorship/Show")]
        public HttpResponseMessage Show()
        {
            var data = MentorshipService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Mentorship/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = MentorshipService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Mentorship/Update")]
        public HttpResponseMessage Update(MentorshipDTO studentDTO)
        {
            try
            {
                var success = MentorshipService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Mentorship updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Mentorship not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}
