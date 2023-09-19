namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'ConcreteImplementorC' class
public class CreditAccount : IAccountImplementor
{
  private decimal _balance;
  private readonly decimal _creditLimit;

  public CreditAccount(decimal initialBalance, decimal creditLimit)
  {
    _balance = initialBalance;
    _creditLimit = creditLimit;
  }

  public decimal GetBalance()
  {
    return _balance - _creditLimit;
  }

  public void UpdateBalance(decimal amount)
  {
    _balance += amount;
  }
}
