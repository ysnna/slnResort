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

namespace slnMaResort.HomeUC
{
    public partial class HomeVoucherUC : UserControl
    {
        public HomeVoucherUC()
        {
            InitializeComponent();
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            if (txtIDVoucher.Text == "" || cbxAreaVoucher.Text == "" || txtNameVoucher.Text == "")
            {
                MessageBox.Show("Thông tin nhập không được để trống");
            }
            else
            {
                addVoucher();
                VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
                txtIDVoucher.Text = "";
                cbxAreaVoucher.Text = "";
                txtNameVoucher.Text = "";
                numPercent.Value = 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int IdVoucher = Int32.Parse(txtIDVoucher.Text);
            string Area = cbxAreaVoucher.Text;
            string NameVoucher = txtNameVoucher.Text;
            DateTime starDate = dtpStareDateVoucher.Value;
            DateTime expriration = dtpExprirationVoucher.Value;
            int precent = Int32.Parse(numPercent.Text);
            DataTable dt = VoucherBLL.Instance.loadAllVou();
            int i = 0;
            while (i < dt.Rows.Count)
            {
                if (IdVoucher.ToString() != dt.Rows[i][0].ToString())
                {
                    i++;
                }
                else
                {
                    VoucherBLL.Instance.updateVou(IdVoucher, Area, NameVoucher, starDate, expriration, precent);
                    MessageBox.Show("Update voucher successed");
                    VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
                    return;
                }
            }
            MessageBox.Show("No ID in table");
        }

        private void btnDeleteVoucher_Click(object sender, EventArgs e)
        {
            int Id = Int32.Parse(txtIDVoucher.Text);
            VoucherBLL.Instance.DeleteVoucher(Id,dgvVoucher);
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvVoucher.CurrentRow.Cells[0].Value);

            DataTable dt = VoucherBLL.Instance.loadAllVouBYID(id);
            txtIDVoucher.Text = dt.Rows[0][0].ToString();
            txtNameVoucher.Text = dt.Rows[0][2].ToString();
            numPercent.Text = dt.Rows[0][5].ToString();
            cbxAreaVoucher.Text = dt.Rows[0][1].ToString();
            dtpExprirationVoucher.Text = dt.Rows[0][4].ToString();
            dtpStareDateVoucher.Text = dt.Rows[0][3].ToString();
        }

        private void HomeVoucherUC_Load(object sender, EventArgs e)
        {
            VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
        }
        void addVoucher()
        {
            int IdVoucher = Int32.Parse(txtIDVoucher.Text);
            string Area = cbxAreaVoucher.Text;
            string NameVoucher = txtNameVoucher.Text;
            DateTime starDate = dtpStareDateVoucher.Value;
            DateTime expriration = dtpExprirationVoucher.Value;
            int precent = Int32.Parse(numPercent.Text);
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
            MessageBox.Show("Thêm voucher thành công");



        }
       
        private void txtIDVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter number");
            }
        }
    }
}
