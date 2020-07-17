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

        int SelectIDTable = 0;

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
                txtPhoneCustomer.Text = dt.Rows[0][1].ToString();
                dtpBookDate.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
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
            if (IsNumber(txtPhoneCustomer.Text) && SelectIDTable != 0)
            {
                string booked = dtpBookDate.Value.ToShortDateString() + " " + dtpBookTime.Value.ToLongTimeString();
                DateTime dateBooked = Convert.ToDateTime(booked);
                string checkin = dtpCheckinDate.Value.ToShortDateString() + " " + dtpCheckinTime.Value.ToLongTimeString();
                DateTime dateCheckin = Convert.ToDateTime(checkin);
                TableBLL.Instance.insertBookTable(SelectIDTable, txtPhoneCustomer.Text, dateBooked, dateCheckin, "Full");
                MessageBox.Show("insert thành công");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void dgvListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvListTable.CurrentRow.Cells[0].Value);
            DataTable dt = TableBLL.Instance.searchIDTableEmpty(id);
            SelectIDTable = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (dt.Rows.Count > 0)
            {
                string state = dt.Rows[0][2].ToString();
                if (state == "Empty") btBook.Enabled = true;
                else btBook.Enabled = false;
            }
        }
    }
}
