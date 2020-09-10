using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.documents
{
    class ExportManager
    {
        private Logger logger;
        private IExportableDocument exportDoc;
        public ExportManager(Logger logger)
        {
            this.logger = logger;
           
        }

        public void ExportToText(Order order)
        {
            exportDoc = new OrderDoc(order);
            Console.WriteLine(exportDoc.toText());
        }
    }
}
