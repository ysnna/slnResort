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
    public partial class ucListEmployee : UserControl
    {
        public ucListEmployee()
        {
            InitializeComponent();
        }

        private void ucListEmployee_Load(object sender, EventArgs e)
        {
            EmployeeBLL.Instance.loadAllEmp(dgvLEmployee);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIDBaseSalary.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtIDCard.Text == "" )
            {
                MessageBox.Show("Thông tin nhập không được để trống");
            }
            else
            {
                int area = EmployeeBLL.Instance.checkArea(GLOBAL.grID);
                switch (area)
                {
                    case 2:
                        conCreateHotelEmp.Instance.insertEmp(EmployeeBLL.Instance.IDEmp(), txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                            txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                    case 3:
                        conCreateParkEMp.Instance.insertEmp(EmployeeBLL.Instance.IDEmp(), txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                                   txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                    case 1:
                        conCreateResEmp.Instance.insertEmp(EmployeeBLL.Instance.IDEmp(), txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                            txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                }

            }
            EmployeeBLL.Instance.loadAllEmp(dgvLEmployee);

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rdoRestaurant_CheckedChanged(object sender, EventArgs e)
        {
            dgvLEmployee.DataSource = conCreateResEmp.Instance.loadEmployee();
        }

        private void rdoHotel_CheckedChanged(object sender, EventArgs e)
        {
            dgvLEmployee.DataSource = conCreateHotelEmp.Instance.loadEmployee();
        }

        private void rdoPark_CheckedChanged(object sender, EventArgs e)
        {
            dgvLEmployee.DataSource = conCreateParkEMp.Instance.loadEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtIDBaseSalary.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtIDCard.Text == "")
            {
                MessageBox.Show("Thông tin nhập không được để trống");
            }
            else
            {
                int area = EmployeeBLL.Instance.checkArea(GLOBAL.grID);
                switch (area)
                {
                    case 2:
                        conCreateHotelEmp.Instance.updateEmp(txtIDEmployee.Text, txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                            txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                    case 3:
                        conCreateParkEMp.Instance.updateEmp(txtIDEmployee.Text, txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                                   txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                    case 1:
                        conCreateResEmp.Instance.updateEmp(txtIDEmployee.Text, txtName.Text, null, dtBrithday.Value, cbbGendar.SelectedIndex, txtAddress.Text,
                            txtIDCard.Text, txtPhone.Text, Convert.ToInt32(txtIDBaseSalary.Text), area, cbbState.Text);
                        break;
                }

            }
            EmployeeBLL.Instance.loadAllEmp(dgvLEmployee);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ID = txtIDEmployee.Text;
            EmployeeBLL.Instance.DeleteEmp(ID);
            EmployeeBLL.Instance.loadAllEmp(dgvLEmployee);
        }
    }
}
