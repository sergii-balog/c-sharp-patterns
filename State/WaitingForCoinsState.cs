namespace C_Sharp_Patterns.State;

// A concrete state class for the waiting for coins state
public class WaitingForCoinsState : State
{
  // Calling the base constructor
  public WaitingForCoinsState(GamblingTerminal terminal) : base(terminal) {}

  // Implementing the abstract methods
  public override void InsertCoin()
  {
    // If a coin is inserted, add it to the balance and display it
    terminal.Balance += 1;
    Console.WriteLine($"Coin inserted. Current balance: {terminal.Balance}.");
  }

  public override void SelectGame()
  {
    // If a game is selected, check if there is enough balance to play
    if (terminal.Balance >= 2)
    {
      // If there is enough balance, change the state to ready to play and display the game name
      //terminal.SetState(new ReadyToPlayState(terminal));
      Console.WriteLine($"Game selected: {terminal.GameName}. Press start to play.");
    }
    else
    {
      // If there is not enough balance, display a message and ask for more coins
      Console.WriteLine("Not enough balance to play. Please insert more coins.");
    }

  }

  public override void StartGame()
  {
    // If the game is started, do nothing (the terminal is not ready to play)
    Console.WriteLine("Please select a game first.");
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
