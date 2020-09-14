using System;
using System.Collections.Generic;
using System.Text;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    class UnknownOrder : OrderHandler
    {
        private OrderProcessor orderProcessor;


        public UnknownOrder(OrderProcessor orderProcessor, ILogger logger) : base(logger)
        {
            this.orderProcessor = orderProcessor;

        }

        public override void Process(Order order)
        {
            logger.Log("unknown order");
        }

    }
}
