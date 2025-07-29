using Microsoft.AspNetCore.Mvc;
using MovieAPI.DTO.DTOs.UserDTOs;

namespace MovieAPI.WebUI.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpDTO signUpDTO)
        {
            return RedirectToAction("SignIn", "User");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
