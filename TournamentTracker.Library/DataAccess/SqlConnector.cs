using TournamentTracker.Library.Models;

namespace TournamentTracker.Library.DataAccess;

public class SqlConnector : IDataConnection
{
    /// TODO - Make the CreatePrize method to actually save to the database
    /// <summary>
    /// Saves a new prize to the Sql database
    /// </summary>
    /// <param name="model">The prize information</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Prize CreatePrize(Prize model)
    {
        throw new NotImplementedException();
    }
}
