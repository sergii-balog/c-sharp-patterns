namespace C_Sharp_Patterns.Command;

public class CommandTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Command pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a calculator receiver object
    CalculatorReceiver receiver = new CalculatorReceiver();

    // Create a calculator service object
    CalculatorService service = new CalculatorService();

    // Create some operation commands with different operands and operations
    ICommand addCommand = new AddCommand(10, 5, receiver);
    ICommand subtractCommand = new SubtractCommand(10, 5, receiver);
    ICommand multiplyCommand = new MultiplyCommand(10, 5, receiver);
    ICommand divideCommand = new DivideCommand(10, 5, receiver);

    // Use the calculator service to perform operations with different commands
    service.PerformOperation(addCommand); // 10 + 5 = 15
    service.PerformOperation(subtractCommand); // 10 - 5 = 5
    service.PerformOperation(multiplyCommand); // 10 * 5 = 50
    service.PerformOperation(divideCommand); // 10 / 5 = 2

    // Use the calculator service to undo operations if needed
    service.UndoOperation(); // Undoing last operation (10 / 5 = 2)
    service.UndoOperation(); // Undoing last operation (10 * 5 = 50)
    service.UndoOperation(); // Undoing last operation (10 - 5 = 5)
    service.UndoOperation(); // Undoing last operation (10 + 5 = 15)
    service.UndoOperation(); // No operations to undo

    // Use the calculator service to redo operations if needed
    service.RedoOperation(); // Redoing last operation (10 + 5 = 15)
    service.RedoOperation(); // Redoing last operation (10 - 5 = 5)
    service.RedoOperation(); // Redoing last operation (10 * 5 = 50)
    service.RedoOperation(); // Redoing last operation (10 / 5 = 2)
    service.RedoOperation(); // No operations to redo
  }
}
