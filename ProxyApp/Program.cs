using System;
using System.Diagnostics.Contracts;

namespace ProxyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        
    }

    interface IBusinessModule
    {
        void Method();
    }

    class BusinessModule: IBusinessModule
    {
        public void Method()
        {
            Console.WriteLine("Method ..");
        }
    }

    class BusinessModuleProxy :IBusinessModule
    {
        private BusinessModule _realObject;

        public BusinessModuleProxy( )
        {
            _realObject = new BusinessModule();
        }

        public void Method()
        {
            Console.WriteLine("Before method.");
            _realObject.Method();
            Console.WriteLine("After Method");
        }
    }
}