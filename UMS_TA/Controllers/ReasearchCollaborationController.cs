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
    public class ReasearchCollaborationController : ApiController
    {
        [HttpPost]
        [Route("api/ReasearchCollaboration/Create")]
        public HttpResponseMessage Create(ReasearchCollaborationDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "ReasearchCollaborationdto cannot be null");
            }

            try
            {
                ReasearchCollaborationService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register ReasearchCollaboration: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/ReasearchCollaboration/Show")]
        public HttpResponseMessage Show()
        {
            var data = ReasearchCollaborationService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/ReasearchCollaboration/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = ReasearchCollaborationService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/ReasearchCollaboration/Update")]
        public HttpResponseMessage Update(ReasearchCollaborationDTO studentDTO)
        {
            try
            {
                var success = ReasearchCollaborationService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "ReasearchCollaboration updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "ReasearchCollaboration not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}
