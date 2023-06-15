namespace C_Sharp_Patterns.BehavioralPatterns.State;

// Other concrete state classes omitted for brevity
// You can find them in this awesome article: https://refactoring.guru/design-patterns/state/csharp/example

// The context class
public class GamblingTerminal
{
  // A private field that holds the current state object
  private State state;

  // Some public properties that store the terminal data
  public int Balance { get; set; }
  public string GameName { get; set; }
  public int Winnings { get; set; }

  // A constructor that sets the initial state to idle
  public GamblingTerminal()
  {
    state = new IdleState(this);
    Console.WriteLine("Welcome to the gambling terminal!");
  }

  // A method that allows changing the state object
  public void SetState(State state)
  {
    this.state = state;
  }

  // Some methods that delegate the requests to the current state object
  public void InsertCoin()
  {
    state.InsertCoin();
  }

  public void SelectGame()
  {
    state.SelectGame();
  }

  public void StartGame()
  {
    state.StartGame();
  }

  public void EndGame()
  {
    state.EndGame();
  }

  public void PayOut()
  {
    state.PayOut();
  }
}
