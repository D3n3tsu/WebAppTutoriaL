using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTutoriaL.Controllers.Api
{
    public class TripController : Controller
    {
        [HttpGet("api/trips")]
        public JsonResult Get()
        {
            return Json(new { Name = "Shawn" });
        }
    }
}
