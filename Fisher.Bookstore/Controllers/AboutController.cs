using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers {
    public class AboutController : Controller {
        public IActionResult Index() {
            return View();
            return Content("This is the About controller's Index action.");
        }
        public IActionResult History() {
            return View();
            return Content("This is the About controller's History action.");
        }
        public IActionResult Location() {
            return View();
            return Content("This is the About controller's Location action.");
        }
    }
}