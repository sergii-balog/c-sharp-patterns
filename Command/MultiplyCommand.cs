namespace C_Sharp_Patterns.Command;

// A concrete command for multiplication
public class MultiplyCommand : ICommand
{
  private int _x;
  private int _y;
  private CalculatorReceiver _receiver;

  public MultiplyCommand(int x, int y, CalculatorReceiver receiver)
  {
    this._x = x;
    this._y = y;
    this._receiver = receiver;
  }

  public void Execute()
  {
    _receiver.Multiply(_x, _y);
  }

  public void Unexecute()
  {
    _receiver.Divide(_x, _y); // To undo multiplication, we need to divide
  }
}
