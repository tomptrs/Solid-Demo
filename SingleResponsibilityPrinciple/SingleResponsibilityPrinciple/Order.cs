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

    public class Item
    {
        public bool IsInStock { get; set; }
    }

    public class Order
    {
        public Customer Customer;
        public Priorty priority = Priorty.low;
        public float Discount { get; set; }
        public OrderType OrderType { get; set; }
        public List<Item> items = new List<Item>();

       
        
      
        public virtual bool IsValid()
        {
            var isValid = true;
            items.ForEach(item =>
            {
                if (!item.IsInStock)
                    isValid = false;
            });

            return true;
        }

    }

    public class PriorityOrder:Order{
        public override bool IsValid()
        {
            items.ForEach(item =>
            {
                if(!item.IsInStock)
                    throw new Exception("no items in stock");
            });
            return true;
        }
    }
}
