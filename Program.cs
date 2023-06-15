﻿using C_Sharp_Patterns;
using C_Sharp_Patterns.ChainOfResponsibility;
using C_Sharp_Patterns.Command;
using C_Sharp_Patterns.Iterator;
using C_Sharp_Patterns.Mediator;
using C_Sharp_Patterns.Observer.BuiltInInterface;
using C_Sharp_Patterns.Observer.CustomInterface;
using C_Sharp_Patterns.Observer.Events;
using C_Sharp_Patterns.State;
using C_Sharp_Patterns.Strategy;
using C_Sharp_Patterns.TemplateMethod;
using C_Sharp_Patterns.Visitor;

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
  new VisitorTestSystem()
};

var tests = new List<ITestSystem>();
tests.AddRange(behavioralPatterns);

Console.WriteLine();
Console.WriteLine("Hello to C# patterns!");

foreach (var test in tests)
{
  await test.Test();
}
