using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.documents
{
    /*
     *
     * Common interface used in applications when there is a need for documents export
     *
     */
    public interface IExportableDocument
    {

        string toText();

        byte[] toPDF();

    }
}
