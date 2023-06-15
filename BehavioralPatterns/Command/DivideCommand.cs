namespace C_Sharp_Patterns.BehavioralPatterns.Command;

// A concrete command for division
public class DivideCommand : ICommand
{
  private int _x;
  private int _y;
  private CalculatorReceiver _receiver;

  public DivideCommand(int x, int y, CalculatorReceiver receiver)
  {
    this._x = x;
    this._y = y;
    this._receiver = receiver;
  }

  public void Execute()
  {
    _receiver.Divide(_x, _y);
  }

  public void Unexecute()
  {
    _receiver.Multiply(_x, _y); // To undo division, we need to multiply
  }
}
