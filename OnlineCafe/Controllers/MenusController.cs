using OnlineCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineCafe.Controllers
{
    public class MenusController : ApiController
    {
        CafeApiContext cafeapicontext = new CafeApiContext();

        [HttpGet]
        public IHttpActionResult Menus() {
            var menus = cafeapicontext.Menus;
            return Ok(menus);
        }
    }
}
