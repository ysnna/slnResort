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

                    bt.ForeColor = Color.Navy;
                    bt.BackColor = flp.BackColor;
                    bt.FlatAppearance.BorderColor = Color.Navy;
                    bt.FlatAppearance.BorderSize = 5;
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Text = item.ID.ToString();
                    flp.Controls.Add(bt);
                    flp.Refresh();
                }
            }
        }
    }
}
