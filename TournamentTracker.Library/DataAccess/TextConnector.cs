using TournamentTracker.Library.Models;

namespace TournamentTracker.Library.DataAccess;

public class TextConnector : IDataConnection
{
    /// TODO - Make the CreatePrize method to actually save to the TextFile
    /// <summary>
    /// Saves a new prize to the TextFile
    /// </summary>
    /// <param name="model">The prize information</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Prize CreatePrize(Prize model)
    {
        throw new NotImplementedException();
    }
}
