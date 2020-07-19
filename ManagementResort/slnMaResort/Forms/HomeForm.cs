using slnMaResort.BLL;
using slnMaResort.DAL;
using slnMaResort.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
           // VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            //id = Convert.ToInt32(dgvVoucher.CurrentRow.Cells[0].Value);

           // DataTable dt = VoucherBLL.Instance.loadAllVouBYID(id);
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
           // VoucherBLL.Instance.insertVou(IdVoucher, Area, NameVoucher, starDate, expriration, precent);
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
               // VoucherBLL.Instance.loadAllVouDGV(dgvVoucher);
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

        private void btnAddS_Click(object sender, EventArgs e)
        {
            int idvoucher = Int32.Parse(txtIDService.Text);
            string name = txtNameService.Text;
            int percent = Int32.Parse(txtDescriptionService.Text);
            int area = Int32.Parse(txt6.Text);
            DateTime startdate = Convert.ToDateTime( txtAreaVoucher.Text);
            DateTime ExprirationDate = Convert.ToDateTime(txtAvailableService.Text);   
            voucherDTO sp = new voucherDTO("Voucher :" + name + " Khu vuc :" + area );

            SqlCommand command = new SqlCommand("Select * From AREA, EMPLOYEE Where AREA.IDArea = EMPLOYEE.IDArea" + idvoucher);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    int id1 = Int32.Parse(table.Rows[i]["_idEmp"].ToString());
            //    string ten = table.Rows[i]["_fullName"].ToString();
            //    string id2 = table.Rows[i]["_idarea"].ToString();
            //    string email = table.Rows[i]["email"].ToString();
            //    EmployeeDTO kh = new EmployeeDTO(_idEmp,_fullName,_idarea,email);
            //    sp.addcus(kh);
            //}
            //sp.ObserverInfo("");
            //sp.updateProduct(id, idcate, name, price, des);
            //loadgridproduct();
        }

        private void homeVoucherUC_Load(object sender, EventArgs e)
        {

        }
    }
}
