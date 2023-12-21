using MvcMovie.Models.Enum;
using Movies = MvcMovie.Models.Movie.Movie;

namespace MvcMovie.Models.Member;

public class Member
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nick { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public AgeInterval AgeInterval { get; set; }
    public List<Platform> SubscribedPlatforms { get; set; }
    public List<Genre> FavoriteGenres { get; set; }
    public List<Movies> FavoriteMovies { get; set; }
    public int Gender { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
