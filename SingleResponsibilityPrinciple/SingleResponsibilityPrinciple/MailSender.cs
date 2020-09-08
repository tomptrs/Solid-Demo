using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class MailSender
    {
        private Logger logger;
        public MailSender()
        {
            logger = new Logger();
        }
        public void SendComfirmationMessage(Order order)
        {
            logger.Log(("Sending comfirmation email"));
            //Send an email to the client
            var name = order.Customer.Name;
            var email = order.Customer.Email;
        }
    }
}
