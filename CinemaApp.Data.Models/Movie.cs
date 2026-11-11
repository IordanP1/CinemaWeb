using CinemaApp.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApp.Data.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(EntityValidation.Movie.TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(EntityValidation.Movie.GenreMaxLength)]
        public string Genre { get; set; } = null!;
        [Column(TypeName = EntityValidation.Movie.ReleaseDateColumType)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(EntityValidation.Movie.DirectorMaxLength)]
        public string Director { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "Duration must be a positive number")]
        public int Duration { get; set; }

        [Required]
        [StringLength(EntityValidation.Movie.DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [MaxLength(EntityValidation.Movie.ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false!;
    }
}
