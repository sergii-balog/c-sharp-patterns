namespace C_Sharp_Patterns.StructuralPatterns.Bridge;

// The 'RefinedAbstractionC' class
public class TransferOperation : IAccountOperation
{
  public IAccountImplementor Implementor { get; set; }

  private readonly IAccountImplementor _target;
  private readonly decimal _amount;

  public TransferOperation(IAccountImplementor target, decimal amount)
  {
    this._target = target;
    this._amount = amount;
  }

  public void Perform()
  {
    Console.WriteLine("Transferring " + _amount + " from the source account to the target account");
    Implementor.UpdateBalance(-_amount);
    _target.UpdateBalance(_amount);
    Console.WriteLine("The new balance of the source account is " + Implementor.GetBalance());
    Console.WriteLine("The new balance of the target account is " + _target.GetBalance());
  }
}
