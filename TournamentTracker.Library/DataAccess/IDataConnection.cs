using TournamentTracker.Library.Models;

namespace TournamentTracker.Library.DataAccess;

public interface IDataConnection
{
    Prize CreatePrize(Prize model);
}
