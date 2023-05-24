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

Console.WriteLine("Below are updated transactions\n\n\n");


accounts[0].MakeWithdrawal(150, DateTime.Now, "Chicken");
accounts[0].MakeWithdrawal(200, DateTime.Now, "Goat");

Console.WriteLine("The Account History is below:");
Console.WriteLine(accounts[0].GetAccountHistory());



foreach (var item in accounts)
{
    Console.WriteLine($"Account {item.AcctNumber} was created for {item.Owner} with balance of {item.Balance}.");
}
