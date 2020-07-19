using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class DetailsInvoiceHotelDAL
    {
        private static DetailsInvoiceHotelDAL instance;
        private DetailsInvoiceHotelDAL() { }
        public static DetailsInvoiceHotelDAL Instance
        {
            get
            {
                if (instance == null) instance = new DetailsInvoiceHotelDAL();
                return DetailsInvoiceHotelDAL.instance;
            }
            private set => DetailsInvoiceHotelDAL.instance = value;
        }

        public DataTable LoadInvoice()
        {
            string sql = @"EXEC LOADINVOICE ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable LoadDetailsRoom(string ID)
        {
            string sql = @"EXEC SELECTDETAILINVOICEROOMFORROOM '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable LoadDetailsService(string ID)
        {
            string sql = @"EXEC SELECTDETAILINVOICESERVICEFORROOM '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
