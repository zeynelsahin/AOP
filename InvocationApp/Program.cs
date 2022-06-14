// See https://aka.ms/new-console-template for more information

using Autofac;
using Autofac.Core;
using Castle.DynamicProxy;
using Entities;
using InvocationApp;

var emp1 = new Employee
{
    Id = 1,
    FirstName = "Ahmet",
    LastName = "Yılmaz"
};
var builder = new ContainerBuilder();
builder.RegisterModule(new DefaultModule());

var container = builder.Build();
var wilBeIntercepted = container.Resolve<IEmployee>();

wilBeIntercepted.Add(emp1.Id,emp1.FirstName,emp1.LastName);

// aspect.Add(1, "Zafer", "Cömert");

