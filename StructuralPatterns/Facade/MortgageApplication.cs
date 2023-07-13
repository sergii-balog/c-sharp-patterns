namespace C_Sharp_Patterns.StructuralPatterns.Facade;

// The 'Facade' class
public class MortgageApplication
{
  private readonly Bank _bank;
  private readonly Credit _credit;
  private readonly Loan _loan;

  public MortgageApplication()
  {
    _bank = new Bank();
    _credit = new Credit();
    _loan = new Loan();
  }

  // The simplified interface for applying for a mortgage
  public bool ApplyForMortgage(Customer customer, double amount)
  {
    Console.WriteLine($"{customer.Name} applies for {amount:C} mortgage\n");

    bool eligible = true;

    // Check bank account balance
    if (!_bank.HasSufficientBalance(customer, amount))
    {
      eligible = false;
      Console.WriteLine("Bank: Insufficient balance");
    }

    // Check credit score
    if (!_credit.HasGoodCredit(customer))
    {
      eligible = false;
      Console.WriteLine("Credit: Poor credit score");
    }

    // Check loan history
    if (!_loan.HasNoBadLoans(customer))
    {
      eligible = false;
      Console.WriteLine("Loan: Bad loan history");
    }

    return eligible;
  }
}
