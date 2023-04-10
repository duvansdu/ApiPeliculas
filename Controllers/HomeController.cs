using aplicacionPel.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aplicacionPel.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(string pelicula)
        {
            var peliculas = await Peliculas.GetReservationAsync(pelicula);
            return View(Enumerable.Repeat(peliculas, 1));
        }

    }
    
}