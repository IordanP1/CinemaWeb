using CinemaApp.Data;
using CinemaApp.Services.Core.Contracts;
using CinemaApp.Services.Core.Data.Movie.Response;
using CinemaApp.Web.ViewModels.Movies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CinemaApp.Web.Controllers
{
    using static GCommon.GlobalConstants;

    public class MovieController : BaseController
    {
        private readonly IMovieService movieService;
        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<GetAllMoviesResponseModel> allMoviesResponseData = await movieService.GetAllMoviesAsync();

            IEnumerable<GetAllMoviesResponseModel> allMoviesViewModel = allMoviesResponseData
                .Select(m => new GetAllMoviesResponseModel()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Genre = m.Genre,
                    Director = m.Director,
                    ReleaseDate = m.ReleaseDate,
                    ImageUrl = m.ImageUrl ?? defaultImageUrl
                });

            return View(allMoviesViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            MovieFormInputModel model = new MovieFormInputModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]MovieFormInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

        }


    } 
}
