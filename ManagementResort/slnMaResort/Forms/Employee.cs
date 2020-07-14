using slnMaResort.DAL;
﻿using slnMaResort.BLL;
using slnMaResort.HomeUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.Forms
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            loadEmpInfo(GLOBAL.empID);

        }


        //Load thong tin nhan vien
        void loadEmpInfo(string ID)
        {
            DataTable empDT = EmployeeDAL.Instance.loadEmpbyID(ID);
            if (empDT.Rows.Count > 0)
            {
                txtIDSalary.Text = empDT.Rows[0][0].ToString();
                try
                {
                    byte[] picPD;
                    picPD = (byte[])empDT.Rows[0][2];
                    MemoryStream pic = new MemoryStream(picPD);
                    this.picAva.Image = Image.FromStream(pic);
                }
                catch
                {
                    MessageBox.Show("Vui lòng cập nhật đủ thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtName.Text = empDT.Rows[0][1].ToString();
                
                txtBirthday.Text = Convert.ToDateTime(empDT.Rows[0][3]).ToShortDateString();
                txtIDCard.Text = empDT.Rows[0][6].ToString();
                if (empDT.Rows[0][4].ToString() == "Female")
                    txtGebder.Text = "Nữ";
                else txtGebder.Text = "Nam";
                txtPhone.Text = empDT.Rows[0][7].ToString();
                txtIDSalary.Text = empDT.Rows[0][8].ToString();
                txtArea.Text = empDT.Rows[0][9].ToString();
                txtState.Text = empDT.Rows[0][10].ToString();
                txtAddress.Text = empDT.Rows[0][5].ToString();
            }
            else
            {
                MessageBox.Show(GLOBAL.username);
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changepw = new ChangePasswordForm();
            changepw.ShowDialog();
        }
        private void picAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }

      
    }
}