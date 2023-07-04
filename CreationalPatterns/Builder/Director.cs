namespace C_Sharp_Patterns.CreationalPatterns.Builder;

// The Director class that controls the construction process
class Director
{
  public void Construct(IBuilder builder)
  {
    builder.BuildEngine();
    builder.BuildWheels();
    builder.BuildColor();
  }
}
