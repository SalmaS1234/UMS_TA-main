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
    public class AlumniController : ApiController
    {
        [HttpPost]
        [Route("api/Alumni/Create")]
        public HttpResponseMessage Create(AlumniDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Alumnidto cannot be null");
            }

            try
            {
                AlumniService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register Alumni: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Alumni/Show")]
        public HttpResponseMessage Show()
        {
            var data = AlumniService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Alumni/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = AlumniService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Alumni/Update")]
        public HttpResponseMessage Update(AlumniDTO studentDTO)
        {
            try
            {
                var success = AlumniService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Alumni updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Alumni not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}
