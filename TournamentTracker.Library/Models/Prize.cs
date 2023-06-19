namespace TournamentTracker.Library.Models;

public class Prize
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Prize"/> class.
    /// </summary>
    public Prize()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Prize"/>
    /// class with specified place number, place name, prize amount, and prize percentage.
    /// </summary>
    /// <param name="placeNumber">The place number of the prize.</param>
    /// <param name="placeName">The name of the place.</param>
    /// <param name="prizeAmount">The amount of the prize.</param>
    /// <param name="prizePercentage">The percentage of the prize.</param>
    public Prize(int placeNumber, string placeName, string prizeAmount, string prizePercentage)
    {
        int placeNumberValue = 0;
        int.TryParse(placeName, out placeNumberValue);
        PlaceNumber = placeNumberValue;

        PlaceName = placeName;

        decimal prizeAmountValue = 0;
        decimal.TryParse(prizeAmount, out prizeAmountValue);
        PrizeAmount = prizeAmountValue;

        double prizePercentageValue = 0;
        double.TryParse(prizePercentage, out prizePercentageValue);
        PrizePercentage = prizePercentageValue;
    }
    /// <summary>
    /// A unique Identifier for the Prize
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The numeric identifier for the place (2 for second place, etc.)
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// The friendly name for the place (second place, first runner up, etc.)
    /// </summary>
    public string PlaceName { get; set; }

    /// <summary>
    /// THe fixed amount this place earns or zero or zero if it not used
    /// </summary>
    public decimal PrizeAmount { get; set; }

    /// <summary>
    /// The number that represents the percentage of the overall take or
    /// zero if it not used. The percentage is a fraction of 1 (so 0.5 for
    /// 50%).
    /// </summary>
    public double PrizePercentage { get; set; }
}