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

        internal static InvoiceDAL Instance 
        {
            get
            {
                if (instance == null) instance = new InvoiceDAL();
                return InvoiceDAL.instance;
            }
            private set => InvoiceDAL.instance = value;
        }

        public DataTable loadInvoice()
        {
            string sql = @"EXEC LOADINVOICE";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public string loadAutoInvoice()
        {
            string sql = @"EXEC AUTOINCREMENTINVOICE";
            DataTable dt = MY_DB.Instance.createTable(sql);
            DataRow dr = dt.Rows[0];
            string idInvoiceNew = dr["IDNewInvoice"].ToString();
            return idInvoiceNew;
        } 

        public DataTable loadInvoiceRoom()
        {
            string sql = @"EXEC SELECTINVOICEROOM";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable loadInvoiceService()
        {
            string sql = @"EXEC SELECTINVOICESERVICE";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable loadInvoiceFood()
        {
            string sql = @"EXEC SELECTINVOICEFOOD";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable loadDetailInvoice(string idInvoice)
        {
            string sql = @"EXEC SELECTDETAILSFROMIDINVOICE '" + idInvoice + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public void insertInvoice(string idInvoice,string idCustomer,string idEmployee,string type,
              DateTime datePayment,float total,int idVoucher,float totalDiscount,float payment,float change,string state)
        {
            string sql = @"EXEC INSERTINVOICE '" + idInvoice + "','" + idCustomer + "','" + idEmployee + "','" + type +
                "','" + datePayment + "','" + total + "','" + idVoucher + "','" + totalDiscount + "','" + payment + "','" + 
                change + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void insertDetailInvoiceFood(string idInvoice,int food,int quantity,float price)
        {
            string sql = @"EXEC INSERTDETAILFOOD '" + idInvoice + "','" + food + "','" + quantity + "','" + price + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void insertDetailInvoiceRoom(string idInvoice,string idRoom,DateTime dateBooked,DateTime dateCheckOut,DateTime checkedOut,float price)
        {
            string sql = @"EXEC INSERTDETAILROOM '" + idInvoice + "','" + idRoom + "','" + dateBooked + "','" + dateCheckOut + "','" + checkedOut + "','" + price + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void insertDetailInvoiceService(string idInvoice,int name,int quantity,float price)
        {
            string sql = @"EXEC INSERTDETAILSERVICE '" + idInvoice + "','" + name + "','" + quantity + "','" + price + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void insertDetailInvoicePark(string idInvoice,int ticket,int quantity,float price)
        {
            string sql = @"EXEC INSERTDETAILPARK '" + idInvoice + "','" + ticket + "','" + quantity + "','" + price + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}
