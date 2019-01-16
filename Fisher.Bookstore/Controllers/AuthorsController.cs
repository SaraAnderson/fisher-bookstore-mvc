using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers {
    public class AuthorsController : Controller {
        
        public IActionResult Index() {
            return Content("This is the Books controller's Authors action.");
        }
        public IActionResult Featured() {
            return Content("This is the Books controller's Featured action.");
        }
    }
}