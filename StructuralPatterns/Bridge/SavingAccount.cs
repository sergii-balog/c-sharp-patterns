namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'ConcreteImplementorB' class
public class SavingAccount : IAccountImplementor
{
  private decimal _balance;
  private readonly decimal _interestRate;

  public SavingAccount(decimal initialBalance, decimal interestRate)
  {
    _balance = initialBalance;
    _interestRate = interestRate;
  }

  public decimal GetBalance()
  {
    return _balance * (1 + _interestRate);
  }

  public void UpdateBalance(decimal amount)
  {
    _balance += amount;
  }
}
