using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankyStuffLibrary;

public class BankAccount
{
    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;

        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        AcctNumber = AccountNumberSeed.ToString();
        AccountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <=0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");

        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

        if (Balance - amount < 0)
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");


        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();

        //HEADER
        report.AppendLine("Date\t\tAmount\tNote");
        foreach (var item in allTransactions)
        {
            //ROWS
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
        }

        return report.ToString();
    }

    public string AcctNumber { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }

    private static int AccountNumberSeed = 1234567890;

    private List<Transaction> allTransactions = new List<Transaction>();
}
