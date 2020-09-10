using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.documents
{
    public class OrderDoc : IExportableDocument
    {
        private Order order;

        public OrderDoc(Order order)
        {
            this.order = order;
        }

        public byte[] toPDF()
        {
            throw new NotImplementedException();
        }

        public string toText()
        {
           StringBuilder sb = new StringBuilder();
           sb.Append("Cusomter : ").Append(order.Customer.Name);
           order.items.ForEach(item =>
           {
               sb.Append("order line: ").Append(item.ToString());
           });

           return sb.ToString();
        }
    }
}
