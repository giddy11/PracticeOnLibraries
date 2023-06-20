using System.Configuration;
using TournamentTracker.Library.Models;

// Load the text file
// Convert the text to List<Prize>
// Find the max ID
// Add the new record with the new ID (max + 1)
// Convert the prizes to List<string>
// Save the List<string> to the text file

namespace TournamentTracker.Library.DataAccess.TextHelpers;

public static class TextConnectorProcessor
{
    public static string FullFilePath(this string fileName)
    {
        // C:\data\TournamentTracker\Prize.csv
        return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    public static List<string> LoadFile(this string file)
    {
        if (!File.Exists(file))
        {
            return new List<string> ();
        }

        return File.ReadAllLines(file).ToList();
    }

    public static List<Prize> ConvertToPrize(this List<string> lines)
    {
        List<Prize> output = new List<Prize>();

        foreach (string line in lines)
        {
            string[] cols = line.Split(',');

            Prize prize = new Prize();
            prize.Id = int.Parse(cols[0]);
            prize.PlaceNumber = int.Parse(cols[1]);
            prize.PlaceName = cols[2];
            prize.PrizeAmount = decimal.Parse(cols[3]);
            prize.PrizePercentage = double.Parse(cols[4]);
            output.Add(prize);
        }

        return output;
    }

    public static void SaveToPrizeFile(this List<Prize> models, string fileName)
    {
        List<string> lines = new List<string>();

        foreach (Prize p in models)
        {
            lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
        }

        File.WriteAllLines(fileName.FullFilePath(), lines);
    }
}
