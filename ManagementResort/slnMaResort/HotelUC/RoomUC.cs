using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.DTO;
using slnMaResort.DAL;
using slnMaResort.BLL;

namespace slnMaResort.HotelUC
{
    public partial class RoomUC : UserControl
    {
        public RoomUC()
        {
            InitializeComponent();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void RoomUC_Load(object sender, EventArgs e)
        {
            LoadRoom(pnTableLayout);
            RoomBLL.Instance.loadTableDGV(dgvRoom);
        }
        public void LoadRoom(FlowLayoutPanel flp)
        {
            List<RoomDTO> roomDTOs = new List<RoomDTO>();
            DataTable dt = new DataTable();
            dt = RoomDAL.Instance.loadRoom();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    RoomDTO roomDTO = new RoomDTO(item);
                    roomDTOs.Add(roomDTO);
                }
                foreach (RoomDTO item in roomDTOs)
                {
                    // 145, 221
                    Button bt = new Button()
                    {
                        Width = RoomDTO.width,
                        Height = RoomDTO.height
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
            string RoomID = ((sender as Button).Tag as RoomDTO).ID;
            RoomDTO.IDRoomSelected = RoomID;
            txtTableID.Text = RoomID.ToString();

        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvRoom.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = RoomBLL.Instance.loadRequimentByID(id);
            txtRequiment.Text = dt.Rows[0][0].ToString();
        }
    }
}
