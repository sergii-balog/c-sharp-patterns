namespace C_Sharp_Patterns.Visitor;

// The Visitor interface
public interface IAccountVisitor
{
  void Visit(SavingsAccount savingsAccount);
  void Visit(CheckingAccount checkingAccount);
  void Visit(CreditCardAccount creditCardAccount);
}
