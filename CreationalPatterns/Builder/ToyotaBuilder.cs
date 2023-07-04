namespace C_Sharp_Patterns.CreationalPatterns.Builder;

// A concrete Builder for one representation
class ToyotaBuilder : IBuilder
{
  private readonly Car _car = new Car();

  public void BuildEngine()
  {
    _car.Add("Hybrid engine");
  }

  public void BuildWheels()
  {
    _car.Add("16-inch wheels");
  }

  public void BuildColor()
  {
    _car.Add("Silver color");
  }

  public Car GetResult()
  {
    return _car;
  }
}

