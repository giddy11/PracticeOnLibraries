using Humanizer;

namespace BankyStuffLibrary;

public class Transaction
{
    public Transaction(decimal amount, DateTime date, string notes)
    {
        Amount = amount;
        Date = date;
        Notes = notes;
    }

    public decimal Amount { get; }
    public string AmountForHumans
    {
        get
        {
            return ((int)Amount).ToWords();
        }
    }
    public DateTime Date { get; }
    public string Notes { get; }
}
