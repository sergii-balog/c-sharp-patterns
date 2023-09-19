namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'Implementor' interface
public interface IAccountImplementor
{
  // A method to get the balance of an account
  decimal GetBalance();

  // A method to update the balance of an account
  void UpdateBalance(decimal amount);
}
