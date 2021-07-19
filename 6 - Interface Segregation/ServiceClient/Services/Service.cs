using ServiceClient.Services.Interfaces;
using System;

namespace ServiceClient.Services
{
    public class Service : IService1, IService2
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}