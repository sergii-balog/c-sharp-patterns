namespace C_Sharp_Patterns.StructuralPatterns.Adapter;

// The 'Adapter' class
public class Adapter : ITarget
{
  private readonly Adaptee _adaptee = new Adaptee();

  public void Request()
  {
    // Possibly do some other work
    // and then call SpecificRequest
    _adaptee.SpecificRequest();
  }
}
