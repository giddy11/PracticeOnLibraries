using TournamentTracker.Library.Models;

namespace TournamentTracker.Library.DatabaseConnection;

public interface IDataConnection
{
    Prize CreatePrize(Prize model);
}
