using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class GardenOrder : OrderHandler
    {
        private OrderProcessor orderProcessor;
        private Logger logger;

        public GardenOrder(OrderProcessor orderProcessor, Logger logger)
        {
            this.orderProcessor = orderProcessor;
            this.logger = logger;
        }

        public override void Process(Order order)
        {
        }
    }
}