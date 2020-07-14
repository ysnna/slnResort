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
    public partial class RoomUC : UserControl
    {
        public RoomUC()
        {
            InitializeComponent();

        }

        private void RoomUC_Load(object sender, EventArgs e)
        {

            TableBLL.Instance.LoadTable(flPicTable);
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            
        }
    }
}
