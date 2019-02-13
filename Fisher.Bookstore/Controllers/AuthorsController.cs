using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers {
    public class AuthorsController : Controller {
        
        public IActionResult Index() {
            return View();
            return Content("This is the Books controller's Authors action.");
        }
        public IActionResult Featured() {
            //we would normally get this from a database
            var featuredAuthor = new Models.Author() {
                AuthorId = 1,
                Name = "J.K. Rowling"
            };
            return View(featuredAuthor);
            return View();
            return Content("This is the Books controller's Featured action.");
        }
    }
}