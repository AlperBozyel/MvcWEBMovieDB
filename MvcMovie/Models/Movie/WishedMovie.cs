using System.ComponentModel.DataAnnotations;
using Members= MvcMovie.Models.Member.Member;


namespace MvcMovie.Models.Movie;

public class WishedMovie : Movie
{
    // person who proposes the movie
    public string Referal { get; set; }

    // List of people you want to watch together with
    public List<Members> WatchTogetherList { get; set; }

}

