using MvcMovie.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MvcMovie.Models;

public class WatchTogether
{
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public string google_url { get; set; }

    public string message { get; set; }

    public Time reminderTime { get; set; }

}

public class Time
{
    public int hour;
    public int minute;
    public Time(int hour, int minute)
    {
        this.hour = hour;
        this.minute = minute;
    }

}