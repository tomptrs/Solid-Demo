using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple
{

    public interface IOrderSource
    {
        string GetOrderFromSource();
    }
    public class FileOrderSource:IOrderSource
    {
       

        public string GetOrderFromSource()
        {
            return File.ReadAllText("order.json");
        
        }
    }
}
