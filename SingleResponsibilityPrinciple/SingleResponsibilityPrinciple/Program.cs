using System;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILogger log = new Logger();
            OrderProcessor processor = new OrderProcessor();
            OrderHandler handler = new ElectronicsOrder(processor,log);
        }
    }
}
