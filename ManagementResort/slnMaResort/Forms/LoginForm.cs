using slnMaResort.BLL;
using slnMaResort.DTO;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {     
            string pass = txtPassword.Text.ToString().Trim();
            string usrname = txtUsername.Text.ToString().Trim();
            if (AccountBLL.Instance.DefinePass(pass, usrname) &&
                AccountBLL.Instance.DefineState(usrname) == "Working")
            {
                MessageBox.Show("Dang nhap  thanh cong");
                AccountBLL.Instance.callForm(usrname);
                GLOBAL.GetUsername(usrname);
            }
            else
            {
                MessageBox.Show("Dang nhap khong thanh cong");
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HomeMemberForm homeMemberForm = new HomeMemberForm();
            homeMemberForm.ShowDialog();
        }
    }
}
