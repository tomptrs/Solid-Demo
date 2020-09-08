using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class SqlConnection: IDisposable
    {
        public SqlConnection(string connection)
        {
                
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
