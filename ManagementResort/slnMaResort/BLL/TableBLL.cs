using slnMaResort.DAL;
using slnMaResort.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.RestaurantUC;

namespace slnMaResort.BLL
{
    public class TableBLL
    {
        private static TableBLL instance;
        private TableBLL() { }
        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return TableBLL.instance;
            }
            private set => TableBLL.instance = value;
        }

        public void loadTableDGV(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadTables();
            dgv.DataSource = dt;
        }
        public void loadTableDGVOCheckOrder(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = TableDAL.Instance.loadTable();
            dgv.DataSource = dt;
        }

        public DataTable loadDesciptrionByID(int ID)
        {
            DataTable dt = TableDAL.Instance.loadDesciptionID(ID);
            return dt;
        }
        /*
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
            //MessageBox.Show(TableDTO.IDTableSelected.ToString());
        }
        */
    }
}
