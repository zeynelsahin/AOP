public class MyClass:IMyClass
{
    [MyInterceptorAspect(Priority = 1)]
    public virtual void MyMethod()//Virtual olmazsa araya girme olmaz
    {
        Console.WriteLine("MyMethod Body..");
    }
}

public interface IMyClass
{
    void MyMethod();
}