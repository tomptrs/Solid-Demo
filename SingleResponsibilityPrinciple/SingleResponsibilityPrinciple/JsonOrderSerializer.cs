using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SingleResponsibilityPrinciple
{
    public class JsonOrderSerializer
    {
      
            public Order GetPolicyFromJsonString(string jsonString)
            {
                return JsonConvert.DeserializeObject<Order>(jsonString,
                    new StringEnumConverter());
            }
        }
    
}
