using CinemaApp.Data;
using CinemaApp.Services.Core.Contracts;
using CinemaApp.Services.Core.Data.Movie.Response;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.Web.Controllers
{

    public class MovieController : Controller
    {
        private readonly IMovieService movieService;
        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<GetAllMoviesResponseModel> allMoviesResponseData = await movieService.GetAllMoviesAsync();

            IEnumerable<GetAllMoviesResponseModel> allMoviesViewModel = allMoviesResponseData
                .Select(m => new GetAllMoviesResponseModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Genre = m.Genre,
                    Director = m.Director,
                });

            return View();
        }
    }
}
