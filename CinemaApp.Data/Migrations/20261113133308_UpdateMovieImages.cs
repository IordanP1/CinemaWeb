using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CinemaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovieImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("17cde096-97c5-429f-83ff-890df87baefc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1896008a-2501-4420-8df7-1786994bc601"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1de6f025-aeaa-4ff5-9445-fbfacf0676fb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("91c0819b-44d5-46b9-9f4d-bfd0c30172d5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c60b241f-3fec-4ebf-bf8d-36659175303f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8c89064-d6b2-4d1f-8e3d-af2a1b02dcb8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("dbca64ed-0b81-4ea6-9377-4ad173a256ce"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e64d53c7-4423-4a7c-8974-75f3d10b3eac"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eace4264-a535-4b78-9b58-f184138a1e7f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f289f916-6558-4776-984e-124f0d4bec2f"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ImageUrl", "IsDeleted", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("03f0477a-8e7c-4ab2-a976-501dc2725ef0"), "The story of J. Robert Oppenheimer and his role in the development of the atomic bomb.", "Christopher Nolan", 180, "Drama", "https://image.tmdb.org/t/p/w500/ptpr0kGAckfQkJeJIt8st5dglvd.jpg", false, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oppenheimer" },
                    { new Guid("175e48da-59ae-4741-b9e8-b50824e8a367"), "A team of explorers travels beyond this galaxy to discover whether mankind has a future among the stars.", "Christopher Nolan", 169, "Sci-Fi", "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg", false, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("3d08796b-438e-42ff-aaff-ddfcca7c4bf6"), "Two imprisoned men form a strong friendship while searching for hope and redemption.", "Frank Darabont", 142, "Drama", "https://image.tmdb.org/t/p/w500/9cqNxx0GxF0bflZmeSMuL5tnGzr.jpg", false, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { new Guid("3d5bafbf-01bb-4ece-9c76-910cd0ccbc91"), "The lives of two hitmen, a boxer and a group of criminals intertwine in unexpected ways.", "Quentin Tarantino", 154, "Crime", "https://posters.movieposterdb.com/12_10/1994/110912/l_110912_17fad32c.jpg", false, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { new Guid("46ec68c2-474c-4cde-a89a-0cdb23ac2163"), "A skilled thief enters people's dreams to steal secrets and is given a seemingly impossible mission.", "Christopher Nolan", 148, "Sci-Fi", "https://image.tmdb.org/t/p/w500/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg", false, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("81fc01c3-88c2-495b-b937-34626f9aaf39"), "A kind-hearted man experiences extraordinary events throughout several decades of American history.", "Robert Zemeckis", 142, "Drama", "https://image.tmdb.org/t/p/w500/arw2vcBveWOVZr6pxd9XTd1TdQa.jpg", false, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { new Guid("c8941bde-81bd-45fc-87d1-a1a8ce24a733"), "Batman faces his greatest challenge when the Joker brings chaos to Gotham City.", "Christopher Nolan", 152, "Action", "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg", false, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { new Guid("eca57d3c-b7d4-4446-8c67-51bfd55b32ea"), "A computer hacker discovers that reality is a simulation controlled by machines.", "Lana Wachowski", 136, "Sci-Fi", "https://image.tmdb.org/t/p/w500/p96dm7sCMn4VYAStA6siNz30G1r.jpg", false, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("f556f114-00ef-4de4-846d-5ead68dd74df"), "A betrayed Roman general seeks revenge against the emperor who destroyed his life.", "Ridley Scott", 155, "Action", "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg", false, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator" },
                    { new Guid("ff12724b-ef28-4b10-9bec-39e99afccb7a"), "The aging patriarch of a powerful crime family transfers control of his empire to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", false, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("03f0477a-8e7c-4ab2-a976-501dc2725ef0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("175e48da-59ae-4741-b9e8-b50824e8a367"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d08796b-438e-42ff-aaff-ddfcca7c4bf6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d5bafbf-01bb-4ece-9c76-910cd0ccbc91"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("46ec68c2-474c-4cde-a89a-0cdb23ac2163"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("81fc01c3-88c2-495b-b937-34626f9aaf39"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c8941bde-81bd-45fc-87d1-a1a8ce24a733"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eca57d3c-b7d4-4446-8c67-51bfd55b32ea"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f556f114-00ef-4de4-846d-5ead68dd74df"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ff12724b-ef28-4b10-9bec-39e99afccb7a"));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "ImageUrl", "IsDeleted", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("17cde096-97c5-429f-83ff-890df87baefc"), "The story of J. Robert Oppenheimer and his role in the development of the atomic bomb.", "Christopher Nolan", 180, "Drama", "https://image.tmdb.org/t/p/w500/ptpr0kGAckfQkJeJIt8st5dglvd.jpg", false, new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oppenheimer" },
                    { new Guid("1896008a-2501-4420-8df7-1786994bc601"), "Two imprisoned men form a strong friendship while searching for hope and redemption.", "Frank Darabont", 142, "Drama", "https://image.tmdb.org/t/p/w500/9cqNxx0GxF0bflZmeSMuL5tnGzr.jpg", false, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { new Guid("1de6f025-aeaa-4ff5-9445-fbfacf0676fb"), "A computer hacker discovers that reality is a simulation controlled by machines.", "Lana Wachowski", 136, "Sci-Fi", "https://image.tmdb.org/t/p/w500/p96dm7sCMn4VYAStA6siNz30G1r.jpg", false, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { new Guid("91c0819b-44d5-46b9-9f4d-bfd0c30172d5"), "The aging patriarch of a powerful crime family transfers control of his empire to his reluctant son.", "Francis Ford Coppola", 175, "Crime", "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7en YsRolD1fZdja1.jpg", false, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { new Guid("c60b241f-3fec-4ebf-bf8d-36659175303f"), "A betrayed Roman general seeks revenge against the emperor who destroyed his life.", "Ridley Scott", 155, "Action", "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg", false, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator" },
                    { new Guid("c8c89064-d6b2-4d1f-8e3d-af2a1b02dcb8"), "A team of explorers travels beyond this galaxy to discover whether mankind has a future among the stars.", "Christopher Nolan", 169, "Sci-Fi", "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg", false, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { new Guid("dbca64ed-0b81-4ea6-9377-4ad173a256ce"), "A skilled thief enters people's dreams to steal secrets and is given a seemingly impossible mission.", "Christopher Nolan", 148, "Sci-Fi", "https://image.tmdb.org/t/p/w500/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg", false, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { new Guid("e64d53c7-4423-4a7c-8974-75f3d10b3eac"), "The lives of two hitmen, a boxer and a group of criminals intertwine in unexpected ways.", "Quentin Tarantino", 154, "Crime", "https://image.tmdb.org/t/p/w500/d5iIlFn5s0ImszYzBPb8JPIfb7.jpg", false, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { new Guid("eace4264-a535-4b78-9b58-f184138a1e7f"), "A kind-hearted man experiences extraordinary events throughout several decades of American history.", "Robert Zemeckis", 142, "Drama", "https://image.tmdb.org/t/p/w500/arw2vcBveWOVZr6pxd9XTd1TdQa.jpg", false, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { new Guid("f289f916-6558-4776-984e-124f0d4bec2f"), "Batman faces his greatest challenge when the Joker brings chaos to Gotham City.", "Christopher Nolan", 152, "Action", "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg", false, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" }
                });
        }
    }
}
