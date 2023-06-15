namespace C_Sharp_Patterns.BehavioralPatterns.Visitor;

// The ConcreteElement class for checking accounts
public class CheckingAccount : IAccount
{
  public double Balance { get; set; }
  public double Rate { get; set; }

  public CheckingAccount(double balance, double rate)
  {
    Balance = balance;
    Rate = rate;
  }

  public void Accept(IAccountVisitor visitor)
  {
    // Call the Visit method for checking accounts on the visitor
    visitor.Visit(this);
  }
}
