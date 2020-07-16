using slnMaResort.DAL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
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
        public void loadEmpbyArea(DataGridView dgv, int area)
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
        

    }
}
