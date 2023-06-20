using C_Sharp_Patterns;
using C_Sharp_Patterns.BehavioralPatterns.ChainOfResponsibility;
using C_Sharp_Patterns.BehavioralPatterns.Command;
using C_Sharp_Patterns.BehavioralPatterns.Interpreter;
using C_Sharp_Patterns.BehavioralPatterns.Iterator;
using C_Sharp_Patterns.BehavioralPatterns.Mediator;
using C_Sharp_Patterns.BehavioralPatterns.Observer.BuiltInInterface;
using C_Sharp_Patterns.BehavioralPatterns.Observer.CustomInterface;
using C_Sharp_Patterns.BehavioralPatterns.Observer.Events;
using C_Sharp_Patterns.BehavioralPatterns.State;
using C_Sharp_Patterns.BehavioralPatterns.Strategy;
using C_Sharp_Patterns.BehavioralPatterns.TemplateMethod;
using C_Sharp_Patterns.BehavioralPatterns.Visitor;
using C_Sharp_Patterns.CreationalPatterns.Singleton;

IEnumerable<ITestSystem> behavioralPatterns = new ITestSystem[]
{
  new ObserverEventsTestSystem(),
  new ObserverCustomInterfaceTestSystem(),
  new ObserverBuiltInInterfaceTestSystem(),
  new StrategyTestSystem(),
  new TemplateMethodTestSystem(),
  new CommandTestSystem(),
  new IteratorTestSystem(),
  new StateTestSystem(),
  new MediatorTestSystem(),
  new ChainOfResponsibilityTestSystem(),
  new VisitorTestSystem(),
  new InterpreterTestSystem()
};

IEnumerable<ITestSystem> creationalPatterns = new[]
{
  new SingletonTestSystem()
};

var tests = new List<ITestSystem>();
//tests.AddRange(behavioralPatterns);
tests.AddRange(creationalPatterns);

Console.WriteLine();
Console.WriteLine("Hello to C# patterns!");

foreach (var test in tests)
{
  await test.Test();
}
