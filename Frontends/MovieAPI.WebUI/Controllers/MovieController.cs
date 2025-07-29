using Microsoft.AspNetCore.Mvc;
using MovieAPI.DTO.DTOs.MovieDTOs;
using Newtonsoft.Json;

namespace MovieAPI.WebUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MovieController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Movies - List";
            ViewBag.v2 = "ABC";
            ViewBag.v3 = "movies list";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7159/api/movies");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDTO>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> MovieDetails(int id) 
        {

            return View();
        }
    }
}
