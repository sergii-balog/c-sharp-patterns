namespace C_Sharp_Patterns.Command;

// The receiver class
public class CalculatorReceiver
{
  public void Add(int x, int y)
  {
    Console.WriteLine($"{x} + {y} = {x + y}");
    // Some logic to perform addition
  }

  public void Subtract(int x, int y)
  {
    Console.WriteLine($"{x} - {y} = {x - y}");
    // Some logic to perform subtraction
  }

  public void Multiply(int x, int y)
  {
    Console.WriteLine($"{x} * {y} = {x * y}");
    // Some logic to perform multiplication
  }
  public void Divide(int x, int y)
  {
    Console.WriteLine($"{x} / {y} = {x / y}");
    // Some logic to perform division
  }
}
