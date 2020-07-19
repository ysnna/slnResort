using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using slnMaResort.DAL;
using slnMaResort.DTO;
using slnMaResort.Forms;
using System.Windows.Forms;
using System.IO;
namespace slnMaResort.BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;
        private EmployeeBLL() { }
        public static EmployeeBLL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeBLL();
                return EmployeeBLL.instance;
            }
            private set => EmployeeBLL.instance = value;
        }

        //Load tất cả nhân viên lên dgv
        public void loadAllEmp(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
            pict = (DataGridViewImageColumn)dgv.Columns[2];
            pict.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataTable dt = EmployeeDAL.Instance.loadEmp();
            dgv.DataSource = dt;
        }
        //Load nhân viên của Khách Sạn
        public void loadEmpbyArea(DataGridView dgv,int area)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
            pict = (DataGridViewImageColumn)dgv.Columns[2];
            pict.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataTable dt = EmployeeDAL.Instance.loadEmpbyArea(area);
            dgv.DataSource = dt;
        }
     
        //Load nhan vien theo ID
        public DataTable loadEmpbyID(string id)
        {
            DataTable dt = EmployeeDAL.Instance.loadEmpbyID(id);
            return dt;
        }
        void insertEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
            , int Gender, string add, string idcard, string phone,
          int IDBaseSalary, int Area, string state)
        {
            EmployeeDAL.Instance.insertEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);
        }
        void updateEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
           , int Gender, string add, string idcard, string phone,
         int IDBaseSalary, int Area, string state)
        {
            EmployeeDAL.Instance.insertEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);
        }

    }
}
