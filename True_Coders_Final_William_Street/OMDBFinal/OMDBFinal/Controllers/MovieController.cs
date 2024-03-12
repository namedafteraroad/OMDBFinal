using Microsoft.AspNetCore.Mvc;
using OMDBFinal.Models;
using Newtonsoft.Json;

namespace OMDBFinal.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> Search(string title)
        {
            var client = new HttpClient();
            var apiKey = "286aaf38";
            var response = await client.GetStringAsync($"http://www.omdbapi.com/?t={title}&apikey={apiKey}");
            var movie = JsonConvert.DeserializeObject<Movie>(response);
            return View(movie);
        }
    }
}
