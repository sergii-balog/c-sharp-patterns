namespace C_Sharp_Patterns.StructuralPatterns.Facade;

// The 'Subsystem ClassA' class
public class Bank
{
  // Check if the customer has sufficient balance in the bank account
  public bool HasSufficientBalance(Customer customer, double amount)
  {
    return customer.Balance >= amount;
  }
}
