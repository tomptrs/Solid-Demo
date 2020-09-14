using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    public class GardenOrder : OrderHandler
    {
        private OrderProcessor orderProcessor;
       

        public GardenOrder(OrderProcessor orderProcessor,ILogger logger):base(logger)
        {
            this.orderProcessor = orderProcessor;
          
        }

        public override void Process(Order order)
        {
        }
    }
}