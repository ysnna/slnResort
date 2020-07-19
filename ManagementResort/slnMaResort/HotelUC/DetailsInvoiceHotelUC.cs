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
using System.Runtime.CompilerServices;

namespace slnMaResort.HotelUC
{
    public partial class DetailsInvoiceHotelUC : UserControl
    {
        public DetailsInvoiceHotelUC()
        {
            InitializeComponent();
        }

        private void DetailsInvoiceHotelUC_Load(object sender, EventArgs e)
        {
            DetailsInvoiceHotelBLL.Instance.LoadInvoice(dgvInvoice);
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvInvoice.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = DetailsInvoiceHotelBLL.Instance.LoadDetailRoom(id);
            dgvDetailRoom.DataSource = dt;

          
            DataTable dt1 = DetailsInvoiceHotelBLL.Instance.LoadDetailService(id);
            if (dt1.Rows.Count >0)
            {
                dgvService.DataSource = dt1;
            }
            else
            {
                
            }    
        }
    }
}
