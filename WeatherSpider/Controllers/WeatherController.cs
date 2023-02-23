using Microsoft.AspNetCore.Mvc;

namespace WeatherSpider.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
