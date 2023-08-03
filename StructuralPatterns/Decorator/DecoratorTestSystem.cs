namespace C_Sharp_Patterns.StructuralPatterns.Decorator;

public class DecoratorTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Decorator pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a personal loan object
    ILoan loan = new PersonalLoan();

    // Wrap it with an insurance decorator
    loan = new InsuranceDecorator(loan);

    // Wrap it with a prepayment decorator
    loan = new PrepaymentDecorator(loan);

    // Print the description and the interest rate of the loan
    Console.WriteLine(loan.GetDescription()); // Personal loan with insurance with prepayment option
    Console.WriteLine(loan.GetInterestRate()); // 0.11 (11% annual interest rate)

    // Create a personal loan object
    loan = new PersonalLoan();
    // Wrap it with a cashback decorator
    loan = new CashbackDecorator(loan);

    // Print the description and the interest rate of the loan
    Console.WriteLine(loan.GetDescription()); // Personal loan with cashback offer
    Console.WriteLine(loan.GetInterestRate()); // 0.15 (15% annual interest rate)
  }
}
