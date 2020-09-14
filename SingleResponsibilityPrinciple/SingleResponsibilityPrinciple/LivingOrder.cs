using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    class LivingOrder:OrderHandler
    {
        private OrderProcessor orderProcessor;

        public LivingOrder(OrderProcessor orderProcessor, ILogger logger):base(logger)
        {
            this.orderProcessor = orderProcessor;
          
        }

        public override void Process(Order order)
        {
        }
    }
}
