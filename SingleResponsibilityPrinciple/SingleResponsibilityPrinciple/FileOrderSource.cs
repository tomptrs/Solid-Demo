using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class FileOrderSource
    {
        public string GetOrderFromFile()
        {
            return File.ReadAllText("order.json");
        }
    }
}
