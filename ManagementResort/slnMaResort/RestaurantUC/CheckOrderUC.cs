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

namespace slnMaResort.RestaurantUC
{
    public partial class CheckOrderUC : UserControl
    {
        public CheckOrderUC()
        {
            InitializeComponent();
        }

        private void CheckOrderUC_Load(object sender, EventArgs e)
        {
            TableBLL.Instance.loadTableDGVOCheckOrder(dgvListTable);
        }
    }
}
