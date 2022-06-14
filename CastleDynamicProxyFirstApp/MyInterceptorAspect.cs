using Castle.DynamicProxy;
using Core.Interceptors;

class MyInterceptorAspect : MethodInterception
{ 
    public override void OnBefore(IInvocation invocation)
    {
        Console.WriteLine($"Before {invocation.Method} ");
    }

    public override void OnAfter(IInvocation invocation)
    {
        Console.WriteLine("After {0}",invocation.Method);
    }
}