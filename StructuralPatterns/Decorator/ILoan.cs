namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'Component' interface
public interface ILoan
{
  // Returns the description of the loan
  string GetDescription();

  // Returns the interest rate of the loan
  double GetInterestRate();
}
