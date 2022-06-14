using Castle.DynamicProxy;
using Core.Interceptors;

namespace InvocationApp;

public class DefensiveProgrammingAspect: MethodInterception
{
    public override void OnBefore(IInvocation invocation)
    {
        var parameters = invocation.Arguments;
        foreach (var parameter in parameters)
        {
            if (parameter.Equals(null))
                throw new ArgumentNullException();
        }

        Console.WriteLine("null check has been completed for {0}",invocation.Method);
    }
}