namespace C_Sharp_Patterns.BehavioralPatterns.Command;

// The invoker class
public class CalculatorService
{
  private Stack<ICommand> _undoStack = new Stack<ICommand>(); // A stack of commands to undo
  private Stack<ICommand> _redoStack = new Stack<ICommand>(); // A stack of commands to redo

  public void PerformOperation(ICommand command)
  {
    _undoStack.Push(command); // Push the command to the undo stack
    _redoStack.Clear(); // Clear the redo stack
    command.Execute(); // Execute the command
  }

  public void UndoOperation()
  {
    if (_undoStack.Count > 0)
    {
      ICommand lastCommand = _undoStack.Pop(); // Pop the last executed command from the undo stack
      _redoStack.Push(lastCommand); // Push it to the redo stack
      lastCommand.Unexecute(); // Unexecute the command
      Console.WriteLine("Undoing last operation");
    }
    else
    {
      Console.WriteLine("No operations to undo");
    }
  }

  public void RedoOperation()
  {
    if (_redoStack.Count > 0)
    {
      ICommand lastCommand = _redoStack.Pop(); // Pop the last unexecuted command from the redo stack
      _undoStack.Push(lastCommand); // Push it to the undo stack
      lastCommand.Execute(); // Execute the command
      Console.WriteLine("Redoing last operation");
    }
    else
    {
      Console.WriteLine("No operations to redo");
    }
  }
}
