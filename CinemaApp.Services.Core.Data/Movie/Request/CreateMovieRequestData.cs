using System.ComponentModel.DataAnnotations;
using static CinemaApp.GCommon.BusinessValidationConstants.Movie;
namespace CinemaApp.Services.Core.Data.Movie.Request
{
    public class CreateMovieRequestData
    {
        [Required(ErrorMessage = TitleRequiredMessage)]
        [MinLength(TitleMinLength, ErrorMessage = TitleMinLengthMessage)]
        [MaxLength(TitleMaxLength, ErrorMessage = TitleMaxLengthMessage)]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = GenreRequiredMessage)]
        [MinLength(GenreMinLength, ErrorMessage = GenreMinLengthMessage)]
        [MaxLength(GenreMaxLength, ErrorMessage = GenreMaxLengthMessage)]
        public string Genre { get; set; } = null!;

        [Required(ErrorMessage = DirectorRequiredMessage)]
        [MinLength(DirectorNameMinLength, ErrorMessage = DirectorMinLengthMessage)]
        [MaxLength(DirectorNameMaxLength, ErrorMessage = DirectorMaxLengthMessage)]
        public string Director { get; set; } = null!;

        [Required(ErrorMessage = DescriptionRequiredMessage)]
        [MinLength(DescriptionMinLength, ErrorMessage = DescriptionMinLengthMessage)]
        [MaxLength(DescriptionMaxLength, ErrorMessage = DescriptionMaxLengthMessage)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = ReleaseDateRequiredMessage)]
        public string ReleaseDate { get; set; } = null!;

        [Range(DurationMinValue, DurationMaxValue, ErrorMessage = DurationRangeMessage)]
        public int Duration { get; set; }

        [MaxLength(ImageUrlMaxLength, ErrorMessage = ImageUrlMaxLengthMessage)]
        public string? ImageUrl { get; set; }
    }
}
