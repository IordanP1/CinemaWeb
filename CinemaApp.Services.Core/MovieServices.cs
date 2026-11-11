using CinemaApp.Data;
using CinemaApp.Services.Core.Contracts;
using CinemaApp.Services.Core.Data.Movie.Response;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Services.Core
{
    public class MovieServices : IMovieService
    {
        private readonly ApplicationDbContext context;
        public MovieServices(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<GetAllMoviesResponseModel>> GetAllMoviesAsync()
        {
            IEnumerable<GetAllMoviesResponseModel> moviesResponseData = await context.Movies
                .OrderByDescending(m => m.Title)
                .ThenBy(m=>m.Id)
                .Select(m => new GetAllMoviesResponseModel
                {
                    Title = m.Title,
                    Genre = m.Genre,
                    Director = m.Director,
                    Description = m.Description,
                    ImageUrl = m.ImageUrl,
                    ReleaseDate = m.ReleaseDate
                })
                .ToArrayAsync();
            return moviesResponseData;
        }
    }
}
