using Microsoft.AspNetCore.Mvc;
using System;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");

        }
    }
}
