namespace C_Sharp_Patterns.StructuralPatterns.Facade;

// The 'Subsystem ClassB' class
public class Credit
{
  // Check if the customer has a good credit score
  public bool HasGoodCredit(Customer customer)
  {
    return customer.CreditScore >= 700;
  }
}
