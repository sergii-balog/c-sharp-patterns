namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

// The 'Decorator' abstract class
public abstract class LoanDecorator : ILoan
{
  // The wrapped loan object
  protected readonly ILoan loan;

  // Constructor that takes an ILoan object as a parameter
  public LoanDecorator(ILoan loanToDecorate)
  {
    this.loan = loanToDecorate;
  }

  // Delegates the GetDescription method to the wrapped loan object
  public virtual string GetDescription()
  {
    return loan.GetDescription();
  }

  // Delegates the GetInterestRate method to the wrapped loan object
  public virtual double GetInterestRate()
  {
    return loan.GetInterestRate();
  }
}
