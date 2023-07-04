namespace C_Sharp_Patterns.CreationalPatterns.Builder;

public class BuilderTestSystem:ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Builder pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a director and two builders
    var director = new Director();
    IBuilder b1 = new ToyotaBuilder();
    IBuilder b2 = new NissanBuilder();

    // Construct two cars using different builders
    director.Construct(b1);
    var car1 = b1.GetResult();
    car1.Display();

    director.Construct(b2);
    var car2 = b2.GetResult();
    car2.Display();
  }
}
