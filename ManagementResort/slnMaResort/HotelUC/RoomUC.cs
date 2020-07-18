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
        string IDRoom = "";
        int IDService = 0;
        private void btBooking_Click(object sender, EventArgs e)
        {

        }

        private void RoomUC_Load(object sender, EventArgs e)
        {
            LoadRoom(pnTableLayout);
            RoomBLL.Instance.loadTableDGV(dgvRoom);
            RoomBLL.Instance.loadBooked(dgvRoomBooked);
            btBooking.Enabled = false;
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
            txtRoomID.Text = RoomID.ToString();
            IDRoom = RoomID;
            RoomBLL.Instance.loadServiceAvailable(dgvServiceAvailable, RoomID);
            //DataTable timeCheckin = TableDAL.Instance.searchCheckinTime(TableID);
            //if (stateNull == "Pre order")
            //{
            //    pnBooked.Visible = true;
            //    cbRent.Checked = true;
            //    datePicker.Value = Convert.ToDateTime(timeCheckin.Rows[0][3].ToString());
            //    timePicker.Value = Convert.ToDateTime(timeCheckin.Rows[0][3].ToString());
            //}
            //else pnBooked.Visible = false;
            //TableDTO.IDTableSelected = TableID;
            //txtTableID.Text = TableID.ToString();
            //TableBLL.Instance.loadDetailsInvoiceFood(dgvOrder, TableID);
            //RoomBLL.Instance.searchDataBookRoom(dgvRoomBooked, txtSearchIDCard.Text);
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvRoom.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = RoomBLL.Instance.loadRequimentByID(id);
            if (dt.Rows.Count > 0)
            {
                txtRoomID.Text = dt.Rows[0][0].ToString();
                txtRequiment.Text = dt.Rows[0][1].ToString();
                string checkState = dt.Rows[0][5].ToString();
                if (checkState == "Empty")
                    btBooking.Enabled = true;
                else btBooking.Enabled = false;
            }
        }
        private void txtSearchIDCard_KeyUp(object sender, KeyEventArgs e)
        {
            RoomBLL.Instance.searchMember(dgvRoomBooked, txtSearchIDCard.Text);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            RoomBLL.Instance.searchMember(dgvRoomBooked, txtSearchIDCard.Text);
        }

        private void dgvRoomBooked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvRoomBooked.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = RoomBLL.Instance.searchDataBookRoom(id);
            if (dt.Rows.Count > 0)
            {
                txtIDCardCustomer.Text = dt.Rows[0][0].ToString();
                txtRoomID.Text = dt.Rows[0][1].ToString();
                dtpDataBooked.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                dtpTimeBooked.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                dtpArrivalDate.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                dtpArrivalTime.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                dtpCheckoutDate.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                dtpCheckoutTime.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                datePicker.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                timePicker.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                cbRent.Checked = true;
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = cbCategory.Text.ToLower();
            if (index == "all") RoomBLL.Instance.loadTableDGV(dgvRoom);
            else RoomBLL.Instance.searchStateRoom(dgvRoom, index);
        }

        private void btBookOrService_Click(object sender, EventArgs e)
        {
            if (dgvBookRoom.Visible == true)
            {
                dgvBookRoom.Visible = false;
            }
            else
            {
                dgvBookRoom.Visible = true;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RoomBLL.Instance.loadServiceAvailable(dgvServiceAvailable, IDRoom);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            RoomBLL.Instance.updateServiceState(IDRoom, IDService, cbStateService.Text);
            MessageBox.Show("Insert thành công");
        }

        private void dgvServiceAvailable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDService = Convert.ToInt32(dgvServiceAvailable.CurrentRow.Cells[0].Value);
        }
    }
}
