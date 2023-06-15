namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define a terminal expression that represents a constant value
public class ConstantExpression : BooleanExpression
{
  // Declare a private field to store the value
  private readonly bool _value;

  // Define a constructor that takes the value as a parameter
  public ConstantExpression(bool value)
  {
    // Assign the value to the field
    _value = value;
  }

  // Override the Interpret method to return the value
  public override bool Interpret(Context context)
  {
    return _value;
  }
}
