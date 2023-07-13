namespace C_Sharp_Patterns.StructuralPatterns.Facade;

public class FacadeTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Facade pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create some customers
    Customer alice = new Customer("Alice", 10000, 700, false);
    Customer bob = new Customer("Bob", 5000, 600, true);
    Customer charlie = new Customer("Charlie", 15000, 800, false);

    // Create a mortgage application facade
    MortgageApplication mortgageApplication = new MortgageApplication();

    // Try to apply for mortgages
    double amount = 12000;

    bool aliceResult = mortgageApplication.ApplyForMortgage(alice, amount);
    Console.WriteLine($"Alice has been {(aliceResult ? "Approved" : "Rejected")}\n");

    bool bobResult = mortgageApplication.ApplyForMortgage(bob, amount);
    Console.WriteLine($"Bob has been {(bobResult ? "Approved" : "Rejected")}\n");

    bool charlieResult = mortgageApplication.ApplyForMortgage(charlie, amount);
    Console.WriteLine($"Charlie has been {(charlieResult ? "Approved" : "Rejected")}\n");
  }
}
