using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.WebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.v1 = "Movies - List";
            ViewBag.v2 = "ABC";
            ViewBag.v3 = "movies list";
            return View();
        }
    }
}
