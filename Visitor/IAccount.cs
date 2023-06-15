namespace C_Sharp_Patterns.Visitor;

// The Element interface
public interface IAccount
{
  void Accept(IAccountVisitor visitor);
}
