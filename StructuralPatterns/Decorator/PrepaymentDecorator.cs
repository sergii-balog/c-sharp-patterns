namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'ConcreteDecorator' class for adding prepayment option
public class PrepaymentDecorator : LoanDecorator
{
  // Constructor that calls the base constructor
  public PrepaymentDecorator(ILoan loan) : base(loan)
  {
  }

  // Overrides the GetDescription method and adds prepayment option
  public override string GetDescription()
  {
    return base.GetDescription() + " with prepayment option";
  }

  // Overrides the GetInterestRate method and subtracts 0.02 from the interest rate
  public override double GetInterestRate()
  {
    return base.GetInterestRate() - 0.02; // 2% lower interest rate for prepayment option
  }
}
