using MvcMovie.Models.Member;
using Members = MvcMovie.Models.Member.Member;

namespace MvcMovie.Models.Movie;

public class UpcomingMovie : Movie
{
    // List of people you want to watch together with
    public List<Members> WatchTogetherList { get; set; }
}