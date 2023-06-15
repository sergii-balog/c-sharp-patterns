namespace C_Sharp_Patterns.BehavioralPatterns.Visitor;

// The Element interface
public interface IAccount
{
  void Accept(IAccountVisitor visitor);
}
