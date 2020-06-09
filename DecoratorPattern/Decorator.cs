using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Decorator : Component
    {
        public Component Component { get; set; }

        public Decorator(Component comp)
        {
            this.Component = comp;
        }
    }
}
