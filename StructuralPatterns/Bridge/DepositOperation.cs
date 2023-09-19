namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'RefinedAbstractionA' class
public class DepositOperation : IAccountOperation
{
  public IAccountImplementor Implementor { get; set; }

  private readonly decimal _amount;

  public DepositOperation(decimal amount)
  {
    _amount = amount;
  }

  public void Perform()
  {
    Console.WriteLine("Depositing " + _amount + " to the account");
    Implementor.UpdateBalance(_amount);
    Console.WriteLine("The new balance is " + Implementor.GetBalance());
  }
}
