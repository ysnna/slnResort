using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.BLL;
using slnMaResort.DAL;
namespace slnMaResort.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btChange_Click(object sender, EventArgs e)
        {
            string enterpass = txtOldPassword.Text.Trim().ToString();
            string newpass = txtNewPassword.Text.Trim().ToString();
            string comfirm = txtConfirmPassword.Text.Trim().ToString();

            AccountBLL.Instance.changePass(enterpass, newpass, comfirm);
        }
    }
}
