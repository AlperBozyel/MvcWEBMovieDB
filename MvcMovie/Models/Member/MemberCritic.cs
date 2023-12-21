using MvcMovie.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models.Member;

public class MemberCritic
{
    public string MovieID { get; set; }
    public string MemberID { get; set; }
    public CriticType CriticType { get; set; }
    public string CriticNote { get; set; }

    [DataType(DataType.Date)]
    public DateTime CriticDate { get; set; }
}