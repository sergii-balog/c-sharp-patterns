namespace C_Sharp_Patterns.StructuralPatterns.Proxy;

// The interface that defines the common methods for both
// the account classes and the proxy class
public interface IAccount
{
  decimal GetBalance();
  void Deposit(decimal amount);
  void Withdraw(decimal amount);
}
