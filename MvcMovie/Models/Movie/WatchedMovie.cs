using MvcMovie.Models.Enum;

namespace MvcMovie.Models.Movie;

public class WatchedMovie : Movie
{
    public float VirtualandCinematographicRate { get; set; }

    public float StoryRate { get; set; }

    public float CharacterRate { get; set; }

    public float SoundandEfectRate { get; set; }

    public float RealisticRate { get; set; }

    public List<string> WatchWith { get; set; }

    public Place WatchPlace { get; set; }
}
