using Microsoft.AspNetCore.Mvc;
using System;

namespace Webtutorial.Controllers.Web
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}