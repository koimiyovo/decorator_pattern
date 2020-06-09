using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component comp) : base(comp)
        {
            
        }

        public override int Method()
        {
            return this.Component.Method() + 2;
        }
    }
}
