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
using slnMaResort.DTO;
using slnMaResort.DAL;

namespace slnMaResort.RestaurantUC
{
    public partial class TablesUC : UserControl
    {
        public TablesUC()
        {
            InitializeComponent();
            LoadTable(pnTableLayout);
            TableBLL.Instance.loadTableDGV(dgvMenu);
        }

        public void LoadTable(FlowLayoutPanel flp)
        {
            List<TableDTO> tableDTOs = new List<TableDTO>();
            DataTable dt = new DataTable();
            dt = TableDAL.Instance.loadTable();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    TableDTO tableDTO = new TableDTO(item);
                    tableDTOs.Add(tableDTO);
                }
                foreach (TableDTO item in tableDTOs)
                {
                    // 145, 221
                    Button bt = new Button()
                    {
                        Width = TableDTO.width,
                        Height = TableDTO.height
                    };
                    bt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);

                    bt.ForeColor = Color.White;
                    bt.BackColor = flp.BackColor;
                    bt.FlatAppearance.BorderColor = Color.White;
                    bt.FlatAppearance.BorderSize = 3;
                    bt.FlatStyle = FlatStyle.Flat;

                    if (item.State == "Empty")
                        bt.BackColor = Color.MediumAquamarine;
                    else
                    if (item.State == "Full")
                        bt.BackColor = Color.DarkKhaki;
                    else
                        bt.BackColor = Color.LightSkyBlue;
                    bt.Click += btTable_Click;
                    bt.Tag = item;
                    bt.Text = item.ID.ToString() + Environment.NewLine + item.State;
                    flp.Controls.Add(bt);
                    flp.Refresh();
                }
            }
        }

        void btTable_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as TableDTO).ID;
            TableDTO.IDTableSelected = TableID;
            txtTableID.Text = TableID.ToString();

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (checkOrderUC.Visible == true)
            {
                checkOrderUC.Visible = false;
                btAddFood.Enabled = true;
            }
            else
            {
                checkOrderUC.Visible = true;
                checkOrderUC.BringToFront();
                btAddFood.Enabled = false;
            }
        }

        public void TablesUC_Load(object sender, EventArgs e)
        {
            //TableListLoad();
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {

        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            DataTable dt = TableBLL.Instance.loadDesciptrionByID(id);
            txtDescription.Text = dt.Rows[0][0].ToString();
        }

        private void pnTableLayout_Click(object sender, EventArgs e)
        {
            txtTableID.Text = TableDTO.IDTableSelected.ToString();
        }
    }
}
