namespace C_Sharp_Patterns.Visitor;

// The ConcreteElement class for credit card accounts
public class CreditCardAccount : IAccount
{
  public double Balance { get; set; }
  public double Rate { get; set; }

  public CreditCardAccount(double balance, double rate)
  {
    Balance = balance;
    Rate = rate;
  }

  public void Accept(IAccountVisitor visitor)
  {
    // Call the Visit method for credit card accounts on the visitor
    visitor.Visit(this);
  }
}
