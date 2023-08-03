namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'ConcreteDecorator' class for adding insurance
public class InsuranceDecorator : LoanDecorator
{
  // Constructor that calls the base constructor
  public InsuranceDecorator(ILoan loan) : base(loan)
  {
  }

  // Overrides the GetDescription method and adds insurance
  public override string GetDescription()
  {
    return base.GetDescription() + " with insurance";
  }

  // Overrides the GetInterestRate method and adds 0.01 to the interest rate
  public override double GetInterestRate()
  {
    return base.GetInterestRate() + 0.01; // 1% extra interest rate for insurance
  }
}
