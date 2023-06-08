namespace C_Sharp_Patterns.State;

// A concrete state class for the idle state
public class IdleState : State
{
  // Calling the base constructor
  public IdleState(GamblingTerminal terminal) : base(terminal) {}

  // Implementing the abstract methods
  public override void InsertCoin()
  {
    // If a coin is inserted, change the state to waiting for coins
    terminal.SetState(new WaitingForCoinsState(terminal));
    Console.WriteLine("Coin inserted. Please insert more coins or select a game.");
  }

  public override void SelectGame()
  {
    // If a game is selected, do nothing (the terminal is not ready to play)
    Console.WriteLine("Please insert coins first.");
  }

  public override void StartGame()
  {
    // If the game is started, do nothing (the terminal is not ready to play)
    Console.WriteLine("Please insert coins and select a game first.");
  }

  public override void EndGame()
  {
    // If the game is ended, do nothing (the terminal is not playing)
    Console.WriteLine("No game in progress.");
  }

  public override void PayOut()
  {
    // If the payout is requested, do nothing (the terminal has no winnings)
    Console.WriteLine("No winnings to pay out.");
  }
}
