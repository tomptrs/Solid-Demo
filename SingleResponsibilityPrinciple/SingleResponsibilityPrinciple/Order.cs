using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public enum Priorty
    {
        low,
        high
    }
    public enum OrderType
    {
        Electronics,
        Garden,
        Living
    }
    public class Order
    {
        public Customer Customer;
        public Priorty priority = Priorty.low;
        public float Discount { get; set; }
        public OrderType OrderType { get; set; }

        public bool IsValid()
        {
            return true;
        }

      
    }
}
