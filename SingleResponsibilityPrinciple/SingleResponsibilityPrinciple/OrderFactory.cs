using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class OrderFactory
    {
        public OrderHandler Create(Order order, OrderProcessor processor)
        {

            switch (order.OrderType)
            {
                case Type.electronics:
                   return new ElectronicsOrder(processor, processor.logger);
                   
                    break;
                case Type.garden:
                   return new GarderOrder(processor, processor.logger);
                 
                    break;
                case Type.living:
                   return new LivingOrder(processor, processor.logger);
                 
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
