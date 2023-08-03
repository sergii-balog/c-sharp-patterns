namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'ConcreteDecorator' class for adding cashback offer
public class CashbackDecorator : LoanDecorator
{
  // Constructor that calls the base constructor
  public CashbackDecorator(ILoan loan) : base(loan)
  {
  }

  // Overrides the GetDescription method and adds cashback offer
  public override string GetDescription()
  {
    return base.GetDescription() + " with cashback offer";
  }

  // Overrides the GetInterestRate method and adds 0.03 to the interest rate
  public override double GetInterestRate()
  {
    return base.GetInterestRate() + 0.03; // 3% extra interest rate for cashback offer
  }
}
