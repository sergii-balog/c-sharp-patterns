namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define a terminal expression that represents a variable name
public class VariableExpression : BooleanExpression
{
  // Declare a private field to store the name
  private readonly string _name;

  // Define a constructor that takes the name as a parameter
  public VariableExpression(string name)
  {
    // Assign the name to the field
    _name = name;
  }

  // Override the Interpret method to return the value of the variable from the context
  public override bool Interpret(Context context)
  {
    return context.GetVariable(_name);
  }
}
