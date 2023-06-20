﻿using Dapper;
using System.Data;
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
        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConString("Tournaments")))
        {
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");

            return model;
        }
    }
}
