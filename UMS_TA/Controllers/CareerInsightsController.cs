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
    public class CareerInsightsController : ApiController
    {
        [HttpPost]
        [Route("api/CareerInsights/Create")]
        public HttpResponseMessage Create(CareerInsightsDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "CareerInsights cannot be null");
            }

            try
            {
                CareerInsightsService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register CareerInsights: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/CareerInsights/Show")]
        public HttpResponseMessage Show()
        {
            var data = CareerInsightsService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/CareerInsights/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = CareerInsightsService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/CareerInsights/Update")]
        public HttpResponseMessage Update(CareerInsightsDTO studentDTO)
        {
            try
            {
                var success = CareerInsightsService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "CareerInsights updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "CareerInsights not found or update failed.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }
    }
}
