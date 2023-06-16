namespace TournamentTracker.Library.Models;

public class MatchupEntry
{
    /// <summary>
    /// Represents one team in the matchup.
    /// </summary>
    public double Score { get; set; }

    /// <summary>
    /// Represents the score for this particular team.
    /// </summary>
    public Team TeamCompeting { get; set; }

    /// <summary>
    /// Represents the matchup that this team came
    /// from as the winner.
    /// </summary>
    public Matchup ParentMatchup { get; set; }
}