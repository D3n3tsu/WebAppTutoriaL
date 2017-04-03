using System;

namespace Webtutorial.Controllers.Web
{
    public class AppController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}