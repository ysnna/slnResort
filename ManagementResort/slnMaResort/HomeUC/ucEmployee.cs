using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.DAL;
using slnMaResort.Forms;

namespace slnMaResort.HomeUC
{
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            loadEmpInfo(GLOBAL.empID);
        }

        //Load thong tin nhan vien
        void loadEmpInfo(string ID)
        {
            DataTable empDT = EmployeeDAL.Instance.loadEmpbyID(ID);

            if (empDT.Rows.Count > 0)
            {
                //lbID.Text = empDT.Rows[0][0].ToString();
                //lbGroup.Text = empDT.Rows[0][1].ToString();
                //try
                //{
                //    byte[] picPD;
                //    picPD = (byte[])empDT.Rows[0][2];
                //    MemoryStream pic = new MemoryStream(picPD);
                //    this.picAva.Image = Image.FromStream(pic);
                //}
                //catch
                //{
                //    MessageBox.Show("Vui lòng cập nhật đủ thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //lbFname.Text = empDT.Rows[0][3].ToString();
                //lbLname.Text = empDT.Rows[0][4].ToString();
                //lbBirthday.Text = Convert.ToDateTime(empDT.Rows[0][5]).ToShortDateString();
                //lbAddress.Text = empDT.Rows[0][6].ToString();
                //if (empDT.Rows[0][7].ToString() == "Female")
                //    lbGender.Text = "Nữ";
                //else lbGender.Text = "Nam";
                //lbPhone.Text = empDT.Rows[0][8].ToString();
                //lbSalary.Text = empDT.Rows[0][9].ToString();
                //lbIDCard.Text = empDT.Rows[0][10].ToString();
            }
            else
            {
                // MessageBox.Show(GLOBAL.username);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepw = new ChangePasswordForm();
            changepw.ShowDialog();
        }

        private void picAva_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            //if (open.ShowDialog() == DialogResult.OK)
            //    picAva.Image = Image.FromFile(open.FileName);
        }
    }
}
