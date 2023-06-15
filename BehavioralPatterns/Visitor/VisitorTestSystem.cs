namespace C_Sharp_Patterns.BehavioralPatterns.Visitor;

public class VisitorTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Visitor pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create some accounts
    SavingsAccount savings = new SavingsAccount(1000, 2);
    CheckingAccount checking = new CheckingAccount(500, 1);
    CreditCardAccount credit = new CreditCardAccount(-1000, 15);

    // Create an InterestRateCalculator visitor
    InterestRateCalculator calculator = new InterestRateCalculator();

    // Use the visitor to calculate the interest rate for each account
    savings.Accept(calculator);
    checking.Accept(calculator);
    credit.Accept(calculator);

    // Print the total interest
    Console.WriteLine($"The total interest is {calculator.TotalInterest}");

  }
}
