using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class InvoiceDAL
    {
        private static InvoiceDAL instance;
        private InvoiceDAL() { }

        internal static InvoiceDAL Instance 
        {
            get
            {
                if (instance == null) instance = new InvoiceDAL();
                return InvoiceDAL.instance;
            }
            private set => InvoiceDAL.instance = value;
        }


    }
}
