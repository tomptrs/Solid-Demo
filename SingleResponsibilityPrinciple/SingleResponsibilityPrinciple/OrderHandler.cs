using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    public abstract class OrderHandler
    {
        protected ILogger logger;
        protected OrderHandler(ILogger logger)
        {
            this.logger = logger;
        }
        public abstract void Process(Order order);

    }
}
