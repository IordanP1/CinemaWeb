using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Services.Core.Data.Movie.Response
{
    public class GetAllMoviesResponseModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
