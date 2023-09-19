namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'Abstraction' interface
public interface IAccountOperation
{
  // A property to get or set the implementor
  IAccountImplementor Implementor { get; set; }

  // A method to perform an operation on an account
  void Perform();
}
