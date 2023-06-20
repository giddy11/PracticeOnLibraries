using TournamentTracker.Library.DataAccess;

namespace TournamentTracker.Library;

public static class GlobalConfig
{
    public static void InitializeConnection(bool database, bool textFiles)
    {
        if (database)
        {
            // TODO - Set up the SQL connector properly
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }

        if (textFiles)
        {
            // TODO - Create the Text Connection
            TextConnector text = new TextConnector();
            Connections.Add(text);
        }
    }
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
}
