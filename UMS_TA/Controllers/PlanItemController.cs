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
    public class PlanItemController : ApiController
    {
        [HttpPost]
        [Route("api/PlanItem/Create")]
        public HttpResponseMessage Create(PlanItemDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, " PlanItemDTO cannot be null");
            }

            try
            {
                PlanItemService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register  PlanItem: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/PlanItem/Show")]
        public HttpResponseMessage Show()
        {
            var data = PlanItemService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/PlanItem/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = PlanItemService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/PlanItem/Update")]
        public HttpResponseMessage Update(PlanItemDTO studentDTO)
        {
            try
            {
                var success = PlanItemService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, " PlanItem updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, " PlanItem not found or update failed.");
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
