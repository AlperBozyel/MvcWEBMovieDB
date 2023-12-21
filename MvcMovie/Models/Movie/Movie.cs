using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using MvcMovie.Models.Enum;

namespace MvcMovie.Models.Movie;

public class Movie
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string? Genre { get; set; }

    public int[] duration { get; set; }

    public List<Platform> Plaform { get; set; }

    public string Nationality { get; set; }

    public Languages Language { get; set; }

    public List<Crew> Directors { get; set; }

    public List<Crew> Producers { get; set; }

    public List<Crew> ArtDirectors { get; set; }

    public List<Crew> SoundDirectors { get; set; }

    public List<Crew> Writer { get; set; }

    public List<Crew> Actors { get; set; }

    public float IMDBRate { get; set; }

    public float MembersRate { get; set; }

    public decimal TotalRate { get; set; }

    public float FriendsRate { get; set; }

    [DataType(DataType.Date)]
    public DateTime WatchDate { get; set; }

    public string WatchWith { get; set; }

    public string Description { get; set; }

    public string movie_image_url { get; set; }

    public string trailer_url { get; set; }

    public string Notes { get; set; }

}

