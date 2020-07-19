using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.BLL
{
    class InvoiceBLL
    {
        private static InvoiceBLL instance;
        private InvoiceBLL() { }
        public static InvoiceBLL Instance
        {
            get
            {
                if (instance == null) instance = new InvoiceBLL();
                return InvoiceBLL.instance;
            }
            private set => InvoiceBLL.instance = value;
        }
        public DataTable createIDInvoice()
        {
            DataTable dt = InvoiceDAL.Instance.createIDInvoice();
            return dt;
        }
    }
}
