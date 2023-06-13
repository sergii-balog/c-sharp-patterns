namespace C_Sharp_Patterns.ChainOfResponsibility;

public class ChainOfResponsibilityTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Chain Of Responsibility pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    var atm = new Atm();

    // Withdraw 90 dollars
    Console.WriteLine("Withdrawing 90$...");
    atm.Withdraw(90);
    Console.WriteLine();

    // Withdraw 40 dollars
    Console.WriteLine("Withdrawing 40$...");
    atm.Withdraw(40);
    Console.WriteLine();

    // Withdraw 75 dollars
    Console.WriteLine("Withdrawing 75$...");
    atm.Withdraw(75);
  }
}
