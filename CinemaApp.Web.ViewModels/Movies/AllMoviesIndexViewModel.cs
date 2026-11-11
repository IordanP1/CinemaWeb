namespace CinemaApp.Web.ViewModels.Movies
{
    public class AllMoviesIndexViewModel
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string ReleaseDate { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int MyProperty { get; set; }
    }
}
