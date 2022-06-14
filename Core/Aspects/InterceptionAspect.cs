using Castle.DynamicProxy;
using Core.Interceptors;

namespace InvocationApp;

public class InterceptionAspect: MethodInterception
{
    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine("Before invocation {0}",invocation.Method);
        Console.WriteLine($"{"Method Name",-20} : {invocation.Method.Name}");
        Console.WriteLine($"{"Target Type",-20} : {invocation.TargetType}");
        Console.WriteLine($"{"Invocation Target Type",-20} : {invocation.TargetType}");
        Console.WriteLine($"{"Proxy ",-20} : {invocation.Proxy}");
        Console.WriteLine("Arguments");
        foreach (var argument in invocation.Arguments)
        {
            Console.WriteLine($"\t {"Type",-12} : {argument.GetType(),-15} | {argument}");
        }

        Console.WriteLine();
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("After invocation {0}",invocation.Method);
    }
}