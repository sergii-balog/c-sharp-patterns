namespace C_Sharp_Patterns.BehavioralPatterns.Visitor;

// The ConcreteElement class for savings accounts
public class SavingsAccount : IAccount
{
  public double Balance { get; set; }
  public double Rate { get; set; }

  public SavingsAccount(double balance, double rate)
  {
    Balance = balance;
    Rate = rate;
  }

  public void Accept(IAccountVisitor visitor)
  {
    // Call the Visit method for savings accounts on the visitor
    visitor.Visit(this);
  }
}
