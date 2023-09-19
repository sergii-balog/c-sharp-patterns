namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'ConcreteImplementorA' class
public class CheckingAccount : IAccountImplementor
{
  private decimal _balance;

  public CheckingAccount(decimal initialBalance)
  {
    _balance = initialBalance;
  }

  public decimal GetBalance()
  {
    return _balance;
  }

  public void UpdateBalance(decimal amount)
  {
    _balance += amount;
  }
}
