using slnMaResort.DAL;
using slnMaResort.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.RestaurantUC;

namespace slnMaResort.BLL
{
    public class TableBLL
    {
        private static TableBLL instance;
        private TableBLL() { }
        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return TableBLL.instance;
            }
            private set => TableBLL.instance = value;
        }

        public void loadTableDGV(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadTables();
            dgv.DataSource = dt;
        }

        public DataTable searchCheckinTime(int idTable)
        {
            DataTable dt = TableDAL.Instance.searchCheckinTime(idTable);
            return dt;
        }

        public void loadTableDGVOCheckOrder(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadTable();
            dgv.DataSource = dt;
        }

        public void loadTableBookTable(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadTableBookTable();
            dgv.DataSource = dt;
        }
        public void searchMember(DataGridView dgv, string phone)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.searchMemberByPhone(phone);
            dgv.DataSource = dt;
        }

        public DataTable searchIDTable(int ID)
        {
            DataTable dt = TableDAL.Instance.searchIDTable(ID);
            return dt;
        }

        public DataTable searchIDTableEmpty(int ID)
        {
            DataTable dt = TableDAL.Instance.searchIDTableEmpty(ID);
            return dt;
        }

        public DataTable loadDesciptrionByID(int ID)
        {
            DataTable dt = TableDAL.Instance.loadDesciptionID(ID);
            return dt;
        }
        public void loadDetailsInvoiceFood(DataGridView dgv, int idTable)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadDetailsInvoiceFood(idTable);
            //MessageBox.Show(dt.Rows[0][0].ToString());
            //MessageBox.Show(dt.Rows[0][2].ToString());
            //MessageBox.Show(dt.Rows[0][3].ToString());
            dgv.DataSource = dt;
        }
        public void insertBookTable(int idTable, string phone, DateTime dateBook, DateTime dateCheckin, string state)
        {
            TableDAL.Instance.insertBookTable(idTable, phone, dateBook, dateCheckin, state);
        }
        public void updateTable(int idTable, string state)
        {
            TableDAL.Instance.updateTable(idTable, state);
        }
    }
}
