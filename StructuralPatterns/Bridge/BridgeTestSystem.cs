namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

public class BridgeTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Bridge pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create an array of operations
    IAccountOperation[] operations = new IAccountOperation[3];
    operations[0] = new DepositOperation(100);
    operations[1] = new WithdrawOperation(50);
    operations[2] = new TransferOperation(new SavingAccount(200, 0.05m), 25);

    // Set the implementor for each operation based on the type of account
    string accountType = "Checking"; // You can change this to "Saving" or "Credit"
    switch (accountType)
    {
      case "Checking":
        foreach (var operation in operations)
        {
          operation.Implementor = new CheckingAccount(100);
        }
        break;
      case "Saving":
        foreach (var operation in operations)
        {
          operation.Implementor = new SavingAccount(100, 0.05m);
        }
        break;
      case "Credit":
        foreach (var operation in operations)
        {
          operation.Implementor = new CreditAccount(100, 500);
        }
        break;
      default:
        Console.WriteLine("Invalid account type");
        break;
    }

    // Perform the operations
    foreach (var operation in operations)
    {
      operation.Perform();
      Console.WriteLine();
    }
  }
}
