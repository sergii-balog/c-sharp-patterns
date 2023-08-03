namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'ConcreteComponent' class
public class PersonalLoan : ILoan
{
  public string GetDescription()
  {
    return "Personal loan";
  }

  public double GetInterestRate()
  {
    return 0.12; // 12% annual interest rate
  }
}
