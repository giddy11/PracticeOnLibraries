namespace TournamentTracker.Library.Models;

public class Team
{
    /// <summary>
    /// The name of the Team.
    /// </summary>
    public string TeamName { get; set; }

    /// <summary>
    /// The set of team members in this tournament.
    /// </summary>
    public List<Person> TeamMembers { get; set; } = new List<Person>();
}
