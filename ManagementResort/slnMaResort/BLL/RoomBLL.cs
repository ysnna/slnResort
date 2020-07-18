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
            dgv.DataSource = null;
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.loadRoom();
            dgv.DataSource = dt;
        }
        public void searchStateRoom(DataGridView dgv, string state)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.searchStateRoom(state);
            dgv.DataSource = dt;
        }
        public void searchMember(DataGridView dgv, string IDCard)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.searchIDcard(IDCard);
            dgv.DataSource = dt;
        }

        public void loadServiceAvailable(DataGridView dgv, string idRoom)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.loadServiceAvailable(idRoom);
            dgv.DataSource = dt;
        }


        public void loadBooked(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = RoomDAL.Instance.loadBooked();
            dgv.DataSource = dt;
        }
        public DataTable loadRequimentByID(string ID)
        {
            DataTable dt = RoomDAL.Instance.loadRequimentID(ID);
            return dt;
        }
        public DataTable searchDataBookRoom(string ID)
        {
            DataTable dt = RoomDAL.Instance.searchDataBookRoom(ID);
            return dt;
        }
        public void updateServiceState(string idRoom, int idService, string state)
        {
            RoomDAL.Instance.updateServiceState(idRoom, idService, state);
        }
    }
}
