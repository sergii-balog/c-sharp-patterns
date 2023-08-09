namespace C_Sharp_Patterns.StructuralPatterns.Proxy;

// A concrete class that implements the interface and
// represents a saving account
public class SavingAccount : IAccount
{
  private decimal balance;
  private decimal interestRate;

  public SavingAccount(decimal initialBalance, decimal interestRate)
  {
    balance = initialBalance;
    this.interestRate = interestRate;
  }

  public decimal GetBalance()
  {
    return balance;
  }

  public void Deposit(decimal amount)
  {
    balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    balance -= amount;
  }

  // A specific method for saving accounts
  public void AddInterest()
  {
    balance += balance * interestRate;
  }
}
