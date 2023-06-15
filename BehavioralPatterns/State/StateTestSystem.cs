namespace C_Sharp_Patterns.BehavioralPatterns.State;

public class StateTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- State pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    GamblingTerminal terminal = new GamblingTerminal();
    terminal.InsertCoin();
    terminal.SelectGame();
    terminal.InsertCoin();
    terminal.InsertCoin();
    terminal.SelectGame();
  }
}
