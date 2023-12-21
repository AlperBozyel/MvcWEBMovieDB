using MvcMovie.Models.Enum;
using Movies = MvcMovie.Models.Movie.Movie;

namespace MvcMovie.Models
{
    public class Crew
    {
        public string PersonelId { get; set; }

        public JobTitle MainJobTitle { get; set; }

        public string Name { get; set; }

        public Dictionary<Movies, JobTitle> Portfolio { get; set; }

    }
}
