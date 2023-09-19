namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'RefinedAbstractionB' class
public class WithdrawOperation : IAccountOperation
{
  public IAccountImplementor Implementor { get; set; }

  private readonly decimal _amount;

  public WithdrawOperation(decimal amount)
  {
    _amount = amount;
  }

  public void Perform()
  {
    Console.WriteLine("Withdrawing " + _amount + " from the account");
    Implementor.UpdateBalance(-_amount);
    Console.WriteLine("The new balance is " + Implementor.GetBalance());
  }
}
