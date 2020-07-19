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
        public void insertInvoice(string idInvoice, string idCustomer, string idEmployee, string type,
              DateTime datePayment, float total, int idVoucher, float totalDiscount, float payment, float change, string state)
        {
            InvoiceDAL.Instance.insertInvoice(idInvoice, idCustomer, idEmployee, type, datePayment, total, idVoucher, totalDiscount, payment, change, state);
        }
        public void insertDetailInvoiceRoom(string idInvoice, string idRoom, DateTime dateBooked, DateTime dateCheckOut, DateTime checkedOut, float price)
        {
            InvoiceDAL.Instance.insertDetailInvoiceRoom(idInvoice, idRoom, dateBooked, dateCheckOut, checkedOut, price);
        }
        public void insertDetailInvoiceService(string idInvoice, int name, int quantity, float price)
        {
            InvoiceDAL.Instance.insertDetailInvoiceService(idInvoice, name, quantity, price);
        }
        public void insertDetailInvoiceFood(string idInvoice, int food, int quantity, float price)
        {
            InvoiceDAL.Instance.insertDetailInvoiceFood(idInvoice, food, quantity, price);
        }
        public void insertDetailInvoicePark(string idInvoice, int ticket, int quantity, float price)
        {
            InvoiceDAL.Instance.insertDetailInvoicePark(idInvoice, ticket, quantity, price);
        }
    }
}
