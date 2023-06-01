namespace C_Sharp_Patterns.Command;

// The command interface
public interface ICommand
{
  void Execute();
  void Unexecute();
}
