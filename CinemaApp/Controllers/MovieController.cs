using CinemaApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Web.Controllers
{

    public class MovieController : Controller
    {
        private readonly ApplicationDbContext context;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
