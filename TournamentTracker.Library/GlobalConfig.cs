using System.Configuration;
using TournamentTracker.Library.DataAccess;

namespace TournamentTracker.Library;

public static class GlobalConfig
{
    public static void InitializeConnection(DatabaseType db)
    {
        switch(db)
        {
            case DatabaseType.Sql:
                // TODO - Set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
                break;

            case DatabaseType.TextFile:
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
                break;

            default:
                break;

        }


        //if (db == DatabaseType.Sql)
        //{
        //    // TODO - Set up the SQL connector properly
        //    SqlConnector sql = new SqlConnector();
        //    Connections = sql;
        //}
        //else if (db == DatabaseType.TextFile)
        //{
        //    // TODO - Create the Text Connection
        //    TextConnector text = new TextConnector();
        //    Connections = text;
        //}
    }

    public static string ConString(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }


    public static IDataConnection Connection { get; private set; }
}
