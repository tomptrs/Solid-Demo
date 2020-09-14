using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    public class ElectronicsOrder:OrderHandler
    {
        private OrderProcessor orderProcessor;


        public ElectronicsOrder(OrderProcessor orderProcessor, ILogger logger):base(logger)
        {
            this.orderProcessor = orderProcessor;
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
