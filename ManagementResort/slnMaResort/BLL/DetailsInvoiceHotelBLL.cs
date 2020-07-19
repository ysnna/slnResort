using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.BLL
{
    class DetailsInvoiceHotelBLL
    {
        private static DetailsInvoiceHotelBLL instance;
        private DetailsInvoiceHotelBLL() { }
        public static DetailsInvoiceHotelBLL Instance
        {
            get
            {
                if (instance == null) instance = new DetailsInvoiceHotelBLL();
                return DetailsInvoiceHotelBLL.instance;
            }
            private set => DetailsInvoiceHotelBLL.instance = value;
        }

        public void LoadInvoice(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            System.Data.DataTable dt = DetailsInvoiceHotelDAL.Instance.LoadInvoice();
            dgv.DataSource = dt;

        }

        public DataTable LoadDetailRoom(string id)
        {
            DataTable dt = DetailsInvoiceHotelDAL.Instance.LoadDetailsRoom(id);
            return dt;
        }
        public DataTable LoadDetailService(string id)
        {
            DataTable dt = DetailsInvoiceHotelDAL.Instance.LoadDetailsService(id);
            return dt;
        }
    }
}