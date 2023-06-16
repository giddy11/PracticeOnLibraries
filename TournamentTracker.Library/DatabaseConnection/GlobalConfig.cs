namespace TournamentTracker.Library.DatabaseConnection;

public static class GlobalConfig
{
    public static void InitializeConnection(bool database, bool textFiles)
    {
        if (database)
        {
            // TODO - Create the SQL Connection
        }

        if (textFiles)
        {
            // TODO - Create the Text Connection
        }
    }
    public static List<IDataConnection> Connections { get; private set; }
}
