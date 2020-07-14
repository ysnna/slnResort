using slnMaResort.BLL;
using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvVoucher.CurrentRow.Cells[0].Value);

            DataTable dt = VoucherBLL.Instance.loadAllVouBYID(id);
            txtIDVoucher.Text = dt.Rows[0][0].ToString();
            txtNameVoucher.Text = dt.Rows[0][2].ToString();
            txtPrecents.Text = dt.Rows[0][5].ToString();
            txtAreaVoucher.Text = dt.Rows[0][1].ToString();
            dtpExprirationDate.Text = dt.Rows[0][4].ToString();
            dtpStartDate.Text = dt.Rows[0][3].ToString();
        }
        void addVoucher()
        {
            int IdVoucher =Int32.Parse (txtIDVoucher.Text);
            string Area = txtAreaVoucher.Text;
            string NameVoucher = txtNameVoucher.Text;
            DateTime starDate = dtpStartDate.Value;
            DateTime expriration = dtpExprirationDate.Value;
            int precent = Int32.Parse(txtPrecents.Text);
            DataTable dt = VoucherBLL.Instance.loadAllVou();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (IdVoucher.ToString() == dt.Rows[i][0].ToString())
                {
                    MessageBox.Show("Trung ID");
                    return;
                } 
            }
            VoucherBLL.Instance.insertVou(IdVoucher, Area, NameVoucher, starDate, expriration, precent);
            MessageBox.Show("TOK");
        }

        private void btnAddV_Click(object sender, EventArgs e)
        {
            
            if (txtIDVoucher.Text =="" || txtAreaVoucher.Text == "" || txtNameVoucher.Text == "")
            {
                MessageBox.Show("Thông tin nhập không được để trống");
            }
            else
            {
                addVoucher();
                VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
            }
        }

        private void txtIDVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập số");
            }
            
        }
    }
}
