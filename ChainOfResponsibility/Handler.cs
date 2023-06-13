namespace C_Sharp_Patterns.ChainOfResponsibility;

// The 'Handler' abstract class
public abstract class Handler
{
  protected Handler? Successor;

  public void SetSuccessor(Handler? successor)
  {
    this.Successor = successor;
  }

  public abstract void HandleRequest(int amount);
}
