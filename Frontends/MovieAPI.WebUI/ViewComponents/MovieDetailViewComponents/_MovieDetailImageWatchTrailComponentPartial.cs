using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailImageWatchTrailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
