using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.BLL;

namespace slnMaResort.RestaurantUC
{
    public partial class CheckOrderUC : UserControl
    {
        public CheckOrderUC()
        {
            InitializeComponent();
        }

        private void CheckOrderUC_Load(object sender, EventArgs e)
        {
            btBook.Enabled = false;
            TableBLL.Instance.loadTableDGVOCheckOrder(dgvListTable);
            TableBLL.Instance.loadTableBookTable(dgvBookTable);
        }

        private void dgvBookTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvBookTable.CurrentRow.Cells[0].Value);
            DataTable dt = TableBLL.Instance.searchIDTable(id);
            if (dt.Rows.Count > 0)
            {
                txtPhoneCustomer.Text= dt.Rows[0][1].ToString();
                dtpBookDate.Value=Convert.ToDateTime(dt.Rows[0][2].ToString());
                dtpBookTime.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                dtpCheckinDate.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                dtpCheckinTime.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            TableBLL.Instance.searchMember(dgvBookTable, txtSearch.Text);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtPhoneCustomer.Text = "";
            txtSearch.Text = "";
            dtpBookDate.Value = DateTime.Now;
            dtpBookTime.Value = DateTime.Now;
            dtpCheckinDate.Value = DateTime.Now;
            dtpCheckinTime.Value = DateTime.Now;
        }

        private void btBook_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
