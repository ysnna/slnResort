using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.HotelUC
{
    public partial class CheckinRoomUC : UserControl
    {
        public CheckinRoomUC()
        {
            InitializeComponent();
        }
        bool checkView = false;
        private void btView_Click(object sender, EventArgs e)
        {
            if (checkView==true)
            { 
                dgvRooms.BringToFront();
                btView.Text = "Rooms";
                checkView = false;
            }
            else
            {
                dgvCustomer.BringToFront();
                btView.Text = "Customers";
                checkView = true;
            }
        }
    }
}
