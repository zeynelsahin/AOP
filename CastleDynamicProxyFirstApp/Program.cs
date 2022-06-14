// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;

Console.WriteLine("Hello, World!");

// light weight  Nesnelerin üzerinde çağrı yapmamıza olanak saglar
// Sınıflar ve arayüzler proxylenebilir
// Yanlızca virtual olan üyeler için araya girme işlemi 
// NHibarete CastleDynamicProxy kullanıyor
        
//En yalın haliyle Aspect

//Aspect Araya girme interception ifadesi olması
var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());
aspect.MyMethod();

Console.WriteLine(new string('-',50));
var builder = new ContainerBuilder();
builder.RegisterType<MyClass>().As<IMyClass>().EnableInterfaceInterceptors(new ProxyGenerationOptions(){Selector = new AspectInterceptorSelector()}).InstancePerDependency();

var container= builder.Build();
var willBeIntercepted= container.Resolve<IMyClass>();
willBeIntercepted.MyMethod();