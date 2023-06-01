namespace C_Sharp_Patterns.Command;

// A concrete command for subtraction
public class SubtractCommand : ICommand
{
  private int _x;
  private int _y;
  private CalculatorReceiver _receiver;

  public SubtractCommand(int x, int y, CalculatorReceiver receiver)
  {
    this._x = x;
    this._y = y;
    this._receiver = receiver;
  }

  public void Execute()
  {
    _receiver.Subtract(_x, _y);
  }

  public void Unexecute()
  {
    _receiver.Add(_x, _y); // To undo subtraction, we need to add
  }
}
