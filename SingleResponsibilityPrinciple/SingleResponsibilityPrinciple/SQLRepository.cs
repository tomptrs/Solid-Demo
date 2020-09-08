using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class SQLRepository
    {
        private Logger logger;
        public SQLRepository()
        {
            logger = new Logger();
        }

        public bool Save(Order order)
        {
            logger.Log("saving order in SQL Database");
            using (SqlConnection con = new SqlConnection("connectionDetails"))
            {
                //save order to SQL DB
            }
            return true;
        }
    }
}
