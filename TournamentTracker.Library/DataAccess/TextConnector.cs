using TournamentTracker.Library.DataAccess.TextHelpers;
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
        // Load the text file and convert to List<Prize>
        List<Prize> prizes = _prizesFile.FullFilePath().LoadFile().ConvertToPrize();

        // Find the max ID
        int currentId = 1;

        if (prizes.Count > 0)
        {
            currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1; 
        }

        model.Id = currentId;

        // Add the new record with the new ID (max + 1)
        prizes.Add(model);

        // Convert the prizes to List<string>
        // Save the List<string> to the text file
        prizes.SaveToPrizeFile(_prizesFile);

        return model;
    }

    private const string _prizesFile = "Prizes.csv";
}
