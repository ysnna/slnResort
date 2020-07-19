using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace slnMaResort.DAL
{
    public class TicketDAL
    {
        private static TicketDAL instance;
        private TicketDAL() { }
        public static TicketDAL Instance
        {
            get
            {
                if (instance == null) instance = new TicketDAL();
                return TicketDAL.instance;
            }
            private set => TicketDAL.instance = value;
        }
        //
        public DataTable loadAllTicket()
        {
            string sql = @"EXEC LOADTICKETBOOKING ";
            DataTable dt1 = MY_DB.Instance.createTable(sql);
            if (dt1.Rows.Count > 0)
                return dt1;
            return null;
        }
        public DataTable loadTicketByID(int id)
        {
            string sql = @"EXEC LOADTICKETBOOKINGBYID  '" + id + "' ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public void insertTicket(int IDticket,string Name,float price,MemoryStream Picture,int Available)
        {
            string sql = @"INSERTTICKET'" + IDticket + "','" + Name + "','" + price + "','" + Picture + "','" + Available + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void updateTicket(int IDticket, string Name, float price, MemoryStream Picture, int Available)
        {
            string sql = @"UPDATETICKET'" + IDticket + "','" + Name + "','" + price + "','" + Picture + "','" + Available + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void deleteTicket(int ID)
        {
            string sql = @"EXEC DELETETICKET'" + ID + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}