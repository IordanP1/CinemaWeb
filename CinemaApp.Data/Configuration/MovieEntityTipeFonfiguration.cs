using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Data.Configuration
{
    public class MovieEntityTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public readonly IEnumerable<Movie> movieSeedData = new List<Movie>
        {
           new Movie
{
    Id = Guid.NewGuid(),
    Title = "Interstellar",
    Genre = "Sci-Fi",
    ReleaseDate = new DateTime(2014, 11, 7),
    Director = "Christopher Nolan",
    Duration = 169,
    Description = "A team of explorers travels beyond this galaxy to discover whether mankind has a future among the stars.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "Inception",
    Genre = "Sci-Fi",
    ReleaseDate = new DateTime(2010, 7, 16),
    Director = "Christopher Nolan",
    Duration = 148,
    Description = "A skilled thief enters people's dreams to steal secrets and is given a seemingly impossible mission.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "The Dark Knight",
    Genre = "Action",
    ReleaseDate = new DateTime(2008, 7, 18),
    Director = "Christopher Nolan",
    Duration = 152,
    Description = "Batman faces his greatest challenge when the Joker brings chaos to Gotham City.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "Oppenheimer",
    Genre = "Drama",
    ReleaseDate = new DateTime(2023, 7, 21),
    Director = "Christopher Nolan",
    Duration = 180,
    Description = "The story of J. Robert Oppenheimer and his role in the development of the atomic bomb.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/ptpr0kGAckfQkJeJIt8st5dglvd.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "The Shawshank Redemption",
    Genre = "Drama",
    ReleaseDate = new DateTime(1994, 9, 23),
    Director = "Frank Darabont",
    Duration = 142,
    Description = "Two imprisoned men form a strong friendship while searching for hope and redemption.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/9cqNxx0GxF0bflZmeSMuL5tnGzr.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "The Matrix",
    Genre = "Sci-Fi",
    ReleaseDate = new DateTime(1999, 3, 31),
    Director = "Lana Wachowski",
    Duration = 136,
    Description = "A computer hacker discovers that reality is a simulation controlled by machines.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/p96dm7sCMn4VYAStA6siNz30G1r.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "Gladiator",
    Genre = "Action",
    ReleaseDate = new DateTime(2000, 5, 5),
    Director = "Ridley Scott",
    Duration = 155,
    Description = "A betrayed Roman general seeks revenge against the emperor who destroyed his life.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "Forrest Gump",
    Genre = "Drama",
    ReleaseDate = new DateTime(1994, 7, 6),
    Director = "Robert Zemeckis",
    Duration = 142,
    Description = "A kind-hearted man experiences extraordinary events throughout several decades of American history.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/arw2vcBveWOVZr6pxd9XTd1TdQa.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "The Godfather",
    Genre = "Crime",
    ReleaseDate = new DateTime(1972, 3, 24),
    Director = "Francis Ford Coppola",
    Duration = 175,
    Description = "The aging patriarch of a powerful crime family transfers control of his empire to his reluctant son.",
    ImageUrl = "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
    IsDeleted = false
},
new Movie
{
    Id = Guid.NewGuid(),
    Title = "Pulp Fiction",
    Genre = "Crime",
    ReleaseDate = new DateTime(1994, 10, 14),
    Director = "Quentin Tarantino",
    Duration = 154,
    Description = "The lives of two hitmen, a boxer and a group of criminals intertwine in unexpected ways.",
    ImageUrl = "https://posters.movieposterdb.com/12_10/1994/110912/l_110912_17fad32c.jpg",
    IsDeleted = false
}
        };


        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(movieSeedData);
        }
    }
}
