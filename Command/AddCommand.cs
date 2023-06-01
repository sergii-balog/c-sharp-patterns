namespace C_Sharp_Patterns.Command;

// A concrete command for addition
public class AddCommand : ICommand
{
  private int _x;
  private int _y;
  private CalculatorReceiver _receiver;

  public AddCommand(int x, int y, CalculatorReceiver receiver)
  {
    this._x = x;
    this._y = y;
    this._receiver = receiver;
  }

  public void Execute()
  {
    _receiver.Add(_x, _y);
  }

  public void Unexecute()
  {
    _receiver.Subtract(_x, _y); // To undo addition, we need to subtract
  }
}
