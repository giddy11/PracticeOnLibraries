using BankyStuffLibrary;

namespace BankingTests;

public class BasicTests
{
    [Fact]
    public void TrueIsTrue()
    {
        Assert.True(true);
    }

    [Fact]
    public void CanTakeMoreThanYouHave()
    {
        var account = new BankAccount("Gideon", 10000);

        // Test for a negative balance

        Assert.Throws<InvalidOperationException>(
            () => account.MakeWithdrawal(80000,
                    DateTime.Now,
                    "Attempt to overdraw")
        );
    }

    [Fact]
    public void NeedMoneyToStart3()
    {
        // Test that the initial balances must be positive.

        Assert.Throws<ArgumentOutOfRangeException>(

            () => new BankAccount("Invalid", -55)

            );
    }
}