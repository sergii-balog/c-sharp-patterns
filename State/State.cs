namespace C_Sharp_Patterns.State;

// The abstract state class
public abstract class State
{
  // The context class
  protected GamblingTerminal terminal;

  // A constructor that takes the context as a parameter
  public State(GamblingTerminal terminal)
  {
    this.terminal = terminal;
  }

  // Some abstract methods that define the common behavior of all states
  public abstract void InsertCoin();
  public abstract void SelectGame();
  public abstract void StartGame();
  public abstract void EndGame();
  public abstract void PayOut();
}
