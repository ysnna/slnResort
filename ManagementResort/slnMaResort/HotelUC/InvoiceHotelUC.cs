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
           // RoomBLL.Instance.loadListRoom(dgv);
        }
    }
}
