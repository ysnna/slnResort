using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using slnMaResort.DAL;
namespace slnMaResort.BLL
{
    public class TicketBLL
    {
        private static TicketBLL instance;
        private TicketBLL() { }
        public static TicketBLL Instance
        {
            get
            {
                if (instance == null) instance = new TicketBLL();
                return TicketBLL.instance;
            }
            private set => TicketBLL.instance = value;
        }
        public void loadAllTicketDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            DataTable dt1 = new DataTable();
            dt1=    TicketDAL.Instance.loadAllTicket();
            if (dt1.Rows.Count > 0)
            {
                dt1 = dt1.DefaultView.ToTable(true, "IDTicketbooking", "Name","Price","Available");
            }
            dgv.DataSource = dt1;
        }

        public DataTable loadAllTicket()
        {
    
            DataTable dt1 = new DataTable();
            dt1 = TicketDAL.Instance.loadAllTicket();
            if (dt1.Rows.Count > 0)
            {
                return dt1;
            }return null;

        }
    }
}
