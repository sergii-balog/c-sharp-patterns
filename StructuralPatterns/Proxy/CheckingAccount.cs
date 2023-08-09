namespace C_Sharp_Patterns.StructuralPatterns.Proxy;

// A concrete class that implements the interface and
// represents a checking account
public class CheckingAccount : IAccount
{
  private decimal balance;

  public CheckingAccount(decimal initialBalance)
  {
    balance = initialBalance;
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
}
