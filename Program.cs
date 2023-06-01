using C_Sharp_Patterns;
using C_Sharp_Patterns.Command;
using C_Sharp_Patterns.Observer.BuiltInInterface;
using C_Sharp_Patterns.Observer.CustomInterface;
using C_Sharp_Patterns.Observer.Events;
using C_Sharp_Patterns.Strategy;
using C_Sharp_Patterns.TemplateMethod;

IEnumerable<ITestSystem> tests = new ITestSystem[]
{
  new ObserverEventsTestSystem(),
  new ObserverCustomInterfaceTestSystem(),
  new ObserverBuiltInInterfaceTestSystem(),
  new StrategyTestSystem(),
  new TemplateMethodTestSystem(),
  new CommandTestSystem()
};

Console.WriteLine();
Console.WriteLine("Hello to C# patterns!");

foreach (var test in tests)
{
  await test.Test();
}
