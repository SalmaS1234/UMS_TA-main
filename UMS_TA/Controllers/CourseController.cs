﻿using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UMS_TA.Controllers
{
    public class CourseController : ApiController
    {
        [HttpPost]
        [Route("api/Course/Create")]
        public HttpResponseMessage Create(CourseDTO s)
        {
            if (s == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Coursedto cannot be null");
            }

            try
            {
                CourseService.Create(s);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Failed to register Course: " + ex.Message);
            }
        }

        [HttpGet]
        [Route("api/Course/Show")]
        public HttpResponseMessage Show()
        {
            var data = CourseService.Show();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/Course/{id}")]
        public HttpResponseMessage Show(int id)
        {
            var data = CourseService.Show(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPut]
        [Route("api/Course/Update")]
        public HttpResponseMessage Update(CourseDTO studentDTO)
        {
            try
            {
                var success = CourseService.Update(studentDTO);
                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Course updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Course not found or update failed.");
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
