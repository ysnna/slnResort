using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using slnMaResort.DAL;
using slnMaResort.DTO;
namespace slnMaResort.BLL
{
    public class VoucherBLL 
    {
        
       
        List<VoucherBLL> listvoucher = new List<VoucherBLL>();
        private static VoucherBLL instance;
        private VoucherBLL() { }
       
        public static VoucherBLL Instance
        {
            get
            {
                if (instance == null) instance = new VoucherBLL();
                return VoucherBLL.instance;
            }
            private set => VoucherBLL.instance = value;
        }
        //
        public DataTable loadAllVouBYID(int ID)
        {
            DataTable dt = VoucherDAL.Instance.loadVoucherbyID(ID);
            return dt;
        }
        public DataTable loadAllVou()
        {
            DataTable dt = VoucherDAL.Instance.loadVoucher();
            return dt;
        }
     

        public void loadAllVouDGV(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            DataTable dt = VoucherDAL.Instance.loadVoucher();

            dgv.DataSource = dt;


        }
        //Them voucher moi
        public void insertVou(int ID, int Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherDAL.Instance.insertVou(ID, Area, Name, StartDate, Expriration, Percents);
        }
        //XOa voucher
        public void deleteVou(int ID)
        {
            VoucherDAL.Instance.deleteVou(ID);
        }

        public void updateVou(int ID, int Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherDAL.Instance.updateVou(ID, Area, Name, StartDate, Expriration, Percents);
        }

      public  void DeleteVoucher(int ID,DataGridView dgv)
        {

            VoucherBLL.Instance.deleteVou(ID);
            MessageBox.Show("Delete succsessed");
            VoucherBLL.Instance.loadAllVouDGV(dgv);

        }

        public DataTable loadVoucherByArea(int area)
        {
            DataTable dt = VoucherDAL.Instance.loadVoucherbyArea(area);
            return dt;
        }
        public void ObserUpdateVoucher(string NameVoucher, int Area, DateTime starDate, DateTime expriration)
        {
            int j = 0;
            VoucherDTO vou = new VoucherDTO("Tên voucher: " + NameVoucher + "Thuộc khu vực:" + Area + "Ngày bắt đầu" + starDate + "Ngày kết thúc: " + expriration);
            DataTable dt1 = VoucherBLL.Instance.loadVoucherByArea(Area);

            for (j = 0; j < dt1.Rows.Count; j++)
            {
                int id1 = int.Parse(dt1.Rows[j]["IDArea"].ToString());
                string idemp = dt1.Rows[j]["IDEmployee"].ToString();

                string email = dt1.Rows[j]["email"].ToString();
                EmployeeDTO emp = new EmployeeDTO(idemp, id1, email);
                vou.addemp(emp);
            }
            vou.ObserverInfo("");
        }
    }
}
