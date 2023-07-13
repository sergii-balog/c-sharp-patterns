namespace C_Sharp_Patterns.StructuralPatterns.Facade;

// The 'Customer' class
public class Customer
{
  // Customer properties
  public string Name { get; set; }
  public double Balance { get; set; }
  public int CreditScore { get; set; }
  public bool HasBadLoans { get; set; }

  // Customer constructor
  public Customer(string name, double balance, int creditScore, bool hasBadLoans)
  {
    Name = name;
    Balance = balance;
    CreditScore = creditScore;
    HasBadLoans = hasBadLoans;
  }
}
