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

namespace slnMaResort.HotelUC
{
    public partial class InvoiceHotelUC : UserControl
    {
        public InvoiceHotelUC()
        {
            InitializeComponent();
        }

        private void InvoiceHotelUC_Load(object sender, EventArgs e)
        {
            RoomBLL.Instance.loadListRoom(dgvListRoom);
        }

        private void dgvListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvListRoom.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = DetailsInvoiceHotelBLL.Instance.LoadDetailRoom(id);
            dgvInvoiceRoom.DataSource = dt;

            DataTable dt1 = DetailsInvoiceHotelBLL.Instance.LoadDetailService(id);
            if (dt1.Rows.Count != null)
            {
                dgvInvoiceService.DataSource = dt1;
            }
            else
            {

            }
            // InvoiceBLL.Instance.loadDetailsRoom(dgvInvoiceRoom, id);
            //InvoiceBLL.Instance.loadDetailsService(dgvInvoiceService, id);
        }
    }
}
