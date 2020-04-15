using OnlineCafe.Data;
using OnlineCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;

namespace OnlineCafe.Controllers
{
    public class ReservationController : ApiController
    {
        CafeApiContext cafeApiContext = new CafeApiContext();


        public IHttpActionResult Post(Reservation reservation){
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            cafeApiContext.Reservations.Add(reservation);
            cafeApiContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
          
    }
}