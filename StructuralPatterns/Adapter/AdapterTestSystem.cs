namespace C_Sharp_Patterns.StructuralPatterns.Adapter;

public class AdapterTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Adapter pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create adapter and place a request
    ITarget target = new Adapter();
    target.Request();
  }
}
