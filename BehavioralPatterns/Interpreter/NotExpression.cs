namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define a non terminal expression that represents a not operation
public class NotExpression : BooleanExpression
{
  // Declare a private field to store the operand
  private readonly BooleanExpression _expression;

  // Define a constructor that takes the operand as a parameter
  public NotExpression(BooleanExpression expression)
  {
    // Assign the operand to the field
    _expression = expression;
  }

  // Override the Interpret method to return the logical negation of the operand's value
  public override bool Interpret(Context context)
  {
    return !_expression.Interpret(context);
  }
}
