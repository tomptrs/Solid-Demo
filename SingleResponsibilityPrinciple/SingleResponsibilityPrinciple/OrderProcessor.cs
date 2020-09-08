using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;

namespace SingleResponsibilityPrinciple
{
    public class OrderProcessor
    {
        public void Process()
        {
            Console.WriteLine("Processing Order...");
            // load policy - open file policy.json
            string orderJson = File.ReadAllText("policy.json");

            var order = JsonConvert.DeserializeObject<Order>(orderJson,
                new StringEnumConverter());

            if (String.IsNullOrEmpty((order.Customer.Name)))
            {
                Console.WriteLine("Order must have o customer name");
            }

            if (order.Customer.Size > 100)
            {
                Console.WriteLine("THis order has high priority, because of the size of the company");
                order.priority = Priorty.high;
            }

            int age = DateTime.Today.Year - order.Customer.DateOfBirth.Year;
            if (order.Customer.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day ==  order.Customer.DateOfBirth.Day)
            {
                Console.WriteLine("customer birthday, so give a discount");
                //calculate a discount
                if (order.priority == Priorty.high)
                    order.Discount = 20;
                else
                    order.Discount = 10;
            }

            if ( Save(order))
            {
                SendComfirmationMessage(order);
            }

        }

        private void SendComfirmationMessage(Order order)
        {
            Console.WriteLine(("Sending comfirmation email"));
           //Send an email to the client
           var name = order.Customer.Name;
           var email = order.Customer.Email;
        }

        public bool Save(Order order)
        {
            Console.WriteLine("saving order in SQL Database");
            using (SqlConnection con = new SqlConnection("connectionDetails"))
            {
                //save order to SQL DB
            }
            return true;
        }


    }
}
