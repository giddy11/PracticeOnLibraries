using BankyStuffLibrary;


var accounts = new List<BankAccount>
{
    new BankAccount("Gideon", 10000),
    new BankAccount("Daniel", 30000),
    new BankAccount("Henry", 15000)
};

foreach (var item in accounts)
{
    Console.WriteLine($"Account {item.AcctNumber} was created for {item.Owner} with balance of {item.Balance}.");
}

Console.WriteLine("Below are updated transactions");

accounts[0].MakeWithdrawal(150, DateTime.Now, "Chicken");
accounts[1].MakeDeposit(-300, DateTime.Now, "stealing");


foreach (var item in accounts)
{
    Console.WriteLine($"Account {item.AcctNumber} was created for {item.Owner} with balance of {item.Balance}.");
}
