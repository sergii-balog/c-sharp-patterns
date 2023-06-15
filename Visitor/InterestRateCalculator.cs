namespace C_Sharp_Patterns.Visitor;

// The ConcreteVisitor class
public class InterestRateCalculator : IAccountVisitor
{
  public double TotalInterest { get; private set; }

  public void Visit(SavingsAccount savingsAccount)
  {
    // Calculate the interest rate for a savings account using its balance and rate
    TotalInterest += savingsAccount.Balance * savingsAccount.Rate / 100 + savingsAccount.Balance / 1000;
  }

  public void Visit(CheckingAccount checkingAccount)
  {
    // Calculate the interest rate for a checking account using its balance and rate
    TotalInterest += checkingAccount.Balance * checkingAccount.Rate / 100 + checkingAccount.Balance / 2000;
  }

  public void Visit(CreditCardAccount creditCardAccount)
  {
    // Calculate the interest rate for a credit card account using its balance and rate
    TotalInterest += creditCardAccount.Balance * creditCardAccount.Rate / 100;
  }
}
