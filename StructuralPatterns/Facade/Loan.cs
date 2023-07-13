namespace C_Sharp_Patterns.StructuralPatterns.Facade;

// The 'Subsystem ClassC' class
public class Loan
{
  // Check if the customer has no bad loans in the past
  public bool HasNoBadLoans(Customer customer)
  {
    return !customer.HasBadLoans;
  }
}
