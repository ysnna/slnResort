using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.BLL
{
    class RoomBLL
    {
        private static RoomBLL instance;
        private RoomBLL() { }
        public static RoomBLL Instance
        {
            get
            {
                if (instance == null) instance = new RoomBLL();
                return RoomBLL.instance;
            }
            private set => RoomBLL.instance = value;
        }

        public void loadTableDGV(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.loadRoom();
            dgv.DataSource = dt;
        }
        public DataTable loadRequimentByID(string ID)
        {
            DataTable dt = RoomDAL.Instance.loadRequimentID(ID);
            return dt;
        }
    }
}
