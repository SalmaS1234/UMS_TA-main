using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;
using UMS_TA.Models;

namespace UMS_TA.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/Login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res = AuthService.Authenticate(login.username, login.password);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);

                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "user not found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,new { Message = ex.Message });
            }
           
        }
        
    }
}
