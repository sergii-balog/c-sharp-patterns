namespace C_Sharp_Patterns.BehavioralPatterns.Command;

// The command interface
public interface ICommand
{
  void Execute();
  void Unexecute();
}
