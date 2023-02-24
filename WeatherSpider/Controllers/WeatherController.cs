using Microsoft.AspNetCore.Mvc;

// to create web request
using System.Net;
using System.Net.Http;
namespace WeatherSpider.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://meteostat.p.rapidapi.com/stations/monthly?station=72502&start=2021-01-01&end=2021-12-31";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method= "GET";

            request.Headers["X-RapidAPI-Key"] = "a975adad98msh92c4681ebfe3889p12b590jsn197f8d456368";
            request.Headers["X-RapidAPI-Host"] = "meteostat.p.rapidapi.com";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

            using var webResponse = request.GetResponse();

            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            return View();
        }
    }
}
