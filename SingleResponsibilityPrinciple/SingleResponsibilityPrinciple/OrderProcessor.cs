using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Channels;
using System.Xml.Linq;
using SingleResponsibilityPrinciple.interfaces;

namespace SingleResponsibilityPrinciple
{
    public class OrderProcessor
    {
        public ILogger logger;
        private IOrderSource orderSource;
        private JsonOrderSerializer jsonOrderSerializer;
        private MailSender mailSender;
        private SQLRepository sqlRepository;

        public OrderProcessor(IOrderSource orderSource)
        {
                logger = new Logger();
                this.orderSource = orderSource;
                jsonOrderSerializer = new JsonOrderSerializer();
                sqlRepository = new SQLRepository();
        }
        public void Process()
        {
           logger.Log("Processing Order...");
            // load policy - open file policy.json
            string orderJson = orderSource.GetOrderFromSource();
            var order = jsonOrderSerializer.GetPolicyFromJsonString(orderJson);

            var factory = new OrderFactory();
            var handler = factory.Create(order, this);
            handler.Process(order);
          /*  if (handler != null)
            {
                handler.Process(order);
            }
            else
            {
                logger.Log("unknown type");
            }*/


            int age = DateTime.Today.Year - order.Customer.DateOfBirth.Year;
            if (order.Customer.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day == order.Customer.DateOfBirth.Day)
            {
                logger.Log("customer birthday, so give a discount");
                //calculate a discount
                if (order.priority == Priorty.high)
                    order.Discount = 20;
                else
                    order.Discount = 10;

            }


            logger.Log("Save to SQL DB");
            if ( sqlRepository.Save(order))
            {
               mailSender.SendComfirmationMessage(order);
            }

        }



      


    }
}
