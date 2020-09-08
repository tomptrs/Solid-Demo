﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class LivingOrder:OrderHandler
    {
        private OrderProcessor orderProcessor;
        private Logger logger;

        public LivingOrder(OrderProcessor orderProcessor, Logger logger)
        {
            this.orderProcessor = orderProcessor;
            this.logger = logger;   
        }

        public override void Process(Order order)
        {
        }
    }
}
