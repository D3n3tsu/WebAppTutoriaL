using Microsoft.AspNetCore.Mvc;
using System;
using WebAppTutoriaL.ViewModels;

namespace Webtutorial.Controllers.Web
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
    }
}