namespace C_Sharp_Patterns.BehavioralPatterns.Interpreter;

public class InterpreterTestSystem: ITestSystem
{
  public async Task Test()
  {
    Console.WriteLine();
    Console.WriteLine("--- Interpreter pattern");
    Console.WriteLine();

    await Task.Delay(1000);

    // Create a context with some variables
    Context context = new Context();
    context.SetVariable("x", true);
    context.SetVariable("y", false);

    // Create an expression: x and y or not x
    BooleanExpression expression = new OrExpression(
      new AndExpression(
        new VariableExpression("x"),
        new VariableExpression("y")
      ),
      new NotExpression(
        new VariableExpression("x")
      )
    );

    // Evaluate the expression with the context
    bool result = expression.Interpret(context);

    // Print the result
    Console.WriteLine($"The result of the expression interpretation is: {result}");
  }
}
