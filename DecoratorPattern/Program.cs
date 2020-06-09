using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component caramel = new ConcreteDecorator(new ConcreteDecorator(new ConcreteDecorator(new ConcreteDecorator(new ConcreteComponent()))));

            Console.WriteLine(caramel.Method());
        }
    }
}
