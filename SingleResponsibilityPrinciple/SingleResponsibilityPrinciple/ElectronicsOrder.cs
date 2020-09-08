using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class ElectronicsOrder:OrderHandler
    {
        private OrderProcessor orderProcessor;
        private Logger logger;

        public ElectronicsOrder(OrderProcessor orderProcessor, Logger logger)
        {
            this.orderProcessor = orderProcessor;
            this.logger = logger;   
        }

        public override void Process(Order order)
        {
            logger.Log("prepare electronics order");
            if (String.IsNullOrEmpty((order.Customer.Name)))
            {
                logger.Log("Order must have o customer name");
            }

            if (order.Customer.Size > 100)
            {
                logger.Log("THis order has high priority, because of the size of the company");
                order.priority = Priorty.high;
            }
        }
    }
}
