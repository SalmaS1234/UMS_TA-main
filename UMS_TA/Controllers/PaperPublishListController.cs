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
    public class PaperPublishListController : ApiController
    {
        [HttpPost]
        [Route("api/PaperPublishLish/Create")]
        public HttpResponseMessage Create(PaperPublishListDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "PaperPublishLishDTO cannot be null");
            }

            try
            {
                PaperPublishService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register PAPERPUBLISH: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/PaperPublishLish/Show")]
        public HttpResponseMessage Show()
        {
            var data = PaperPublishService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/PaperPublishLish/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = PaperPublishService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/PaperPublishLish/Update")]
        public HttpResponseMessage Update(PaperPublishListDTO PaperPublishLishDTO)
        {
            try
            {
                var success = PaperPublishService.Update(PaperPublishLishDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "PaperPublishLish updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "PaperPublishLisH not found or update failed.");
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
