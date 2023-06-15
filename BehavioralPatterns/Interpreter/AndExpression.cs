namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

// Define a non terminal expression that represents an and operation
public class AndExpression : BooleanExpression
{
  // Declare private fields to store the left and right operands
  private readonly BooleanExpression _left;
  private readonly BooleanExpression _right;

  // Define a constructor that takes the left and right operands as parameters
  public AndExpression(BooleanExpression left, BooleanExpression right)
  {
    // Assign the operands to the fields
    _left = left;
    _right = right;
  }

  // Override the Interpret method to return the logical and of the operands' values
  public override bool Interpret(Context context)
  {
    return _left.Interpret(context) && _right.Interpret(context);
  }
}
