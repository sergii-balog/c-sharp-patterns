namespace C_Sharp_Patterns.CreationalPatterns.Builder;

// The Builder interface
interface IBuilder
{
  void BuildEngine();
  void BuildWheels();
  void BuildColor();
  Car GetResult();
}
