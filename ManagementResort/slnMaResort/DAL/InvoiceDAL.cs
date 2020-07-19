using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class InvoiceDAL
    {
        private static InvoiceDAL instance;
        private InvoiceDAL() { }
        public static InvoiceDAL Instance
        {
            get
            {
                if (instance == null) instance = new InvoiceDAL();
                return InvoiceDAL.instance;
            }
            private set => InvoiceDAL.instance = value;
        }
        public DataTable createIDInvoice()
        {
            string sql = @"EXEC AUTOINCREMENTINVOICE ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
