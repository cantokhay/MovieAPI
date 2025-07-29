using Microsoft.AspNetCore.Mvc;
using MovieAPI.DTO.DTOs.UserDTOs;
using Newtonsoft.Json;

namespace MovieAPI.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDTO signUpDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(signUpDTO);
            StringContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7159/api/Users", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("SignIn", "User");
            }
            ViewBag.Error = "An error occurred while signing up. Please try again.";
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
