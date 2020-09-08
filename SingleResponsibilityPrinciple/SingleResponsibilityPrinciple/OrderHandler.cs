using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public abstract class OrderHandler
    {
        public abstract void Process(Order order);

    }
}
