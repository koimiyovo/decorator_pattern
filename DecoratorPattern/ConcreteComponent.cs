using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteComponent : Component
    {
        public override int Method()
        {
            return 1;
        }
    }
}
