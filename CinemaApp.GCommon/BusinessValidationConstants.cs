namespace CinemaApp.GCommon
{
    public static class BusinessValidationConstants
    {
        public static class Movie
        {
            // Title
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 100;

            public const string TitleRequiredMessage = "Movie title is required.";
            public const string TitleMinLengthMessage = "Movie title must be at least 2 characters.";
            public const string TitleMaxLengthMessage = "Movie title cannot be longer than 100 characters.";

            // Genre
            public const int GenreMinLength = 3;
            public const int GenreMaxLength = 50;

            public const string GenreRequiredMessage = "Movie genre is required.";
            public const string GenreMinLengthMessage = "Movie genre must be at least 3 characters.";
            public const string GenreMaxLengthMessage = "Movie genre cannot be longer than 50 characters.";

            // Director
            public const int DirectorNameMinLength = 2;
            public const int DirectorNameMaxLength = 50;

            public const string DirectorRequiredMessage = "Director name is required.";
            public const string DirectorMinLengthMessage = "Director name must be at least 2 characters.";
            public const string DirectorMaxLengthMessage = "Director name cannot be longer than 50 characters.";

            // Description
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1000;

            public const string DescriptionRequiredMessage = "Movie description is required.";
            public const string DescriptionMinLengthMessage = "Movie description must be at least 10 characters.";
            public const string DescriptionMaxLengthMessage = "Movie description cannot be longer than 1000 characters.";

            // Release Date
            public const string ReleaseDateFormat = "yyyy-MM-dd";
            public const string ReleaseDateRequiredMessage = "Release date is required.";

            // Duration
            public const int DurationMinValue = 1;
            public const int DurationMaxValue = 500;

            public const string DurationRangeMessage = "Movie duration must be between 1 and 500 minutes.";

            // Image URL
            public const int ImageUrlMaxLength = 2048;
            public const string ImageUrlMaxLengthMessage = "Image URL cannot be longer than 2048 characters.";
        }
    }
}
