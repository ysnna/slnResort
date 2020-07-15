using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;
using slnMaResort.DAL;

namespace slnMaResort.BLL
{
    public class VoucherBLL
    {
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
        public void inserVoucher(int IdVoucher, string Area, string NameVoucher, DateTime startDate, DateTime expriration, int precent)
        {
            VoucherDAL.Instance.insertVou(IdVoucher, Area, NameVoucher, startDate, expriration, precent);
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
        public void insertVou(int ID, string Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherDAL.Instance.insertVou(ID, Area, Name, StartDate, Expriration, Percents);
        }
        //XOa voucher
        public void deleteVou(int ID)
        {
            VoucherDAL.Instance.deleteVou(ID);
        }

        public void updateVou(int ID, string Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherDAL.Instance.updateVou(ID, Area, Name, StartDate, Expriration, Percents);
        }
    }
}
