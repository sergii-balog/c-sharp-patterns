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
using C_Sharp_Patterns.CreationalPatterns.AbstractFactory;
using C_Sharp_Patterns.CreationalPatterns.Builder;
using C_Sharp_Patterns.CreationalPatterns.FactoryMethod;
using C_Sharp_Patterns.CreationalPatterns.Prototype;
using C_Sharp_Patterns.CreationalPatterns.Singleton;
using C_Sharp_Patterns.StructuralPatterns.Adapter;
using C_Sharp_Patterns.StructuralPatterns.Bridge;
using C_Sharp_Patterns.StructuralPatterns.Decorator;
using C_Sharp_Patterns.StructuralPatterns.Facade;
using C_Sharp_Patterns.StructuralPatterns.Proxy;

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

IEnumerable<ITestSystem> creationalPatterns = new ITestSystem[]
{
  new SingletonTestSystem(),
  new FactoryMethodTestSystem(),
  new BuilderTestSystem(),
  new PrototypeTestSystem(),
  new AbstractFactoryTestSystem()
};

IEnumerable<ITestSystem> structuralPatterns= new ITestSystem[]
{
  new FacadeTestSystem(),
  new AdapterTestSystem(),
  new DecoratorTestSystem(),
  new ProxyTestSystem(),
  new BridgeTestSystem()
};

var tests = new List<ITestSystem>();
tests.AddRange(behavioralPatterns);
tests.AddRange(creationalPatterns);
tests.AddRange(structuralPatterns);

Console.WriteLine();
Console.WriteLine("Hello from C# patterns!");

foreach (var test in tests)
{
  await test.Test();
}
