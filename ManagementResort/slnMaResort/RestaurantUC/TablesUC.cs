using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.RestaurantUC
{
    public partial class TablesUC : UserControl
    {
        public TablesUC()
        {
            InitializeComponent();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (checkOrderUC.Visible == true)
                checkOrderUC.Visible = false;
            else
            {
                checkOrderUC.Visible = true;
               
            }
        }

        #region TableOrder
        public void TableListLoad()
        {
            pnTableLayout.Controls.Clear();
            List<table> tableList = new List<table>();
            //TableOrder tbO = new TableOrder();
            DataTable dt = new DataTable();
            //dt = tbO.LoadTable();
            foreach (DataRow item in dt.Rows)
            {
                table table = new table(item);
                tableList.Add(table);
            }

            foreach (table item in tableList)
            {
                Button bnt = new Button() { Width = table.TableWidth, Height = table.tableHeight };
                bnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bnt.ForeColor = Color.Yellow;
                if (item.Status == "Trống")
                    bnt.BackColor = Color.Blue;
                else
                    if (item.Status == "Bận")
                    bnt.BackColor = Color.Red;
                else
                    bnt.BackColor = Color.Chocolate;
                bnt.Text = item.Name + Environment.NewLine + item.Status;
                //bnt.Click += bntTable_Click;
                bnt.Tag = item;
                pnTableLayout.Controls.Add(bnt);
                pnTableLayout.Refresh();
            }
        }

        #endregion

        private void TablesUC_Load(object sender, EventArgs e)
        {
            TableListLoad();
        }
    }
}
