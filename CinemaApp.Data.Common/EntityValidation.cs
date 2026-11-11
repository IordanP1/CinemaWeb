using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Common
{
    public static class EntityValidation
    {
        public static class Movie
        {
            public const int TitleMaxLength = 100;
            public const int GenreMaxLength = 50;
            public const int DirectorMaxLength = 50;
            public const int DescriptionMaxLength = 500;
            public const int ImageUrlMaxLength = 2048;
            public const string ReleaseDateColumType = "smalldatetime";
        }
    }
}
