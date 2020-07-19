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
using System.Globalization;

namespace slnMaResort.HotelUC
{
    public partial class CheckinRoomUC : UserControl
    {
        public CheckinRoomUC()
        {
            InitializeComponent();
        }

        bool checkClick = false;
        DataTable getInfoBooked;
        ServicesDTO listServices = new ServicesDTO();
        List<ServicesDTO> getListServices = new List<ServicesDTO>();
        BookRoomDTO listBookRoom = new BookRoomDTO();
        List<BookRoomDTO> getListBookRoom = new List<BookRoomDTO>();

        private void CheckinRoomUC_Load(object sender, EventArgs e)
        {
            dtpDateBooked.Value = DateTime.Now;
            dtpTimeBooked.Value = DateTime.Now;
            DataTable dt = CustomerBLL.Instance.createIDCustomer();
            txtIDCustomer.Text = dt.Rows[0][0].ToString();
            DataTable ivc = InvoiceBLL.Instance.createIDInvoice();
            txtidInvoice.Text = ivc.Rows[0][0].ToString();
            RoomBLL.Instance.loadBooked(dgvBooked);
            RoomBLL.Instance.loadListRoom(dgvListRoom);
            ServicesBLL.Instance.loadServices(dgvServices);
        }

        private void btAddServices_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            RoomBLL.Instance.searchMember(dgvBooked, txtSearch.Text);
        }

        private void btAddCustomerBooked_Click(object sender, EventArgs e)
        {
            if (checkClick == true)
            {
                listBookRoom.IDRoom = txtIDRoom.Text;
                string booked = dtpDateBooked.Value.ToShortDateString() + " " + dtpTimeBooked.Value.ToShortTimeString();
                listBookRoom.DateBooked = Convert.ToDateTime(booked);
                string checkin = dtpDateCheckin.Value.ToShortDateString() + " " + dtpTimeCheckin.Value.ToShortTimeString();
                listBookRoom.DateCheckin = Convert.ToDateTime(checkin);
                string checkout = dtpDateCheckout.Value.ToShortDateString() + " " + dtpTimeCheckout.Value.ToShortTimeString();
                listBookRoom.DateCheckout = Convert.ToDateTime(checkout);
                DataTable price = RoomBLL.Instance.searchPriceRoom(txtIDRoom.Text);
                listBookRoom.Price = Convert.ToDouble(price.Rows[0][4].ToString());
                dgvCheckin.Rows.Add(listBookRoom.IDRoom, listBookRoom.DateBooked, listBookRoom.DateCheckin, listBookRoom.DateCheckout, listBookRoom.Price);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtIDCard.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            dtpBirthday.Value = DateTime.Now;
            radMale.Checked = true;
            txtIDRoom.Text = "ID Room";
            dtpDateCheckin.Value = DateTime.Now;
            dtpTimeCheckin.Value = DateTime.Now;
            dtpDateCheckout.Value = DateTime.Now;
            dtpTimeCheckout.Value = DateTime.Now;
            dtpDateBooked.Value = DateTime.Now;
            dtpTimeBooked.Value = DateTime.Now;
        }

        private void dgvBooked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvBooked.CurrentRow.Cells[0].Value.ToString();
            getInfoBooked = RoomBLL.Instance.searchDataBookRoom(id);
            if (getInfoBooked.Rows.Count > 0)
            {
                checkClick = true;
                txtIDCard.Text = getInfoBooked.Rows[0][0].ToString();
                txtIDRoom.Text = getInfoBooked.Rows[0][1].ToString();
                dtpDateBooked.Value = Convert.ToDateTime(getInfoBooked.Rows[0][2].ToString());
                dtpTimeBooked.Value = Convert.ToDateTime(getInfoBooked.Rows[0][2].ToString());
                dtpDateCheckin.Value = Convert.ToDateTime(getInfoBooked.Rows[0][3].ToString());
                dtpTimeCheckin.Value = Convert.ToDateTime(getInfoBooked.Rows[0][3].ToString());
                dtpDateCheckout.Value = Convert.ToDateTime(getInfoBooked.Rows[0][4].ToString());
                dtpTimeCheckout.Value = Convert.ToDateTime(getInfoBooked.Rows[0][4].ToString());
                //listBookRoom.
            }
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvServices.CurrentCell.RowIndex;
            listServices = new ServicesDTO();
            listServices.IDService = Convert.ToInt32(dgvServices.Rows[index].Cells[0].Value);
            listServices.Name = dgvServices.Rows[index].Cells[1].Value.ToString();
            listServices.Price = Convert.ToDouble(dgvServices.Rows[index].Cells[3].Value);
            listServices.Available = Convert.ToInt32(numAvailable.Value);
            dgvBookServices.Rows.Add(listServices.IDService, listServices.Name, listServices.Available, listServices.Price);
        }

        private void dgvBookServices_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvBookServices.CurrentCell.RowIndex;
            if (dgvBookServices.SelectedRows.Count > 0)
            {
                dgvBookServices.Rows.RemoveAt(dgvBookServices.CurrentRow.Index);
                getListServices.Remove(listServices);
            }
        }

        private void dgvListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = dgvListRoom.CurrentRow.Cells[0].Value.ToString();
            string state = dgvListRoom.CurrentRow.Cells[5].Value.ToString();
            if (state == "Full")
            {
                btAddServices.Enabled = true;
                btCheckin.Enabled = false;
                txtidInvoice.Visible = false;
                DataTable dt = RoomBLL.Instance.searchCustomer(id);
                txtIDRoom.Text = id;
                MessageBox.Show(dt.Rows[0][4].ToString());
                MessageBox.Show(dt.Rows[0][2].ToString());
                txtIDCustomer.Text = dt.Rows[0][0].ToString();
                txtName.Text = dt.Rows[0][1].ToString();
                txtPhone.Text = dt.Rows[0][4].ToString();
                txtIDCard.Text = dt.Rows[0][5].ToString();
                //dtpBirthday.Value = Convert.ToDateTime(dt.Rows[0][2]);
                radMale.Checked = true;
                //int gender = Convert.ToInt32(dt.Rows[0][3].ToString());
                //if (gender == 1) radFemale.Checked = true;
                //else radMale.Checked = true;
                dtpDateCheckin.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
                dtpTimeCheckin.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
                dtpDateCheckout.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
                dtpTimeCheckout.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
            }
            else
            {
                btAddServices.Enabled = false;
                btCheckin.Enabled = true;
                txtidInvoice.Visible = true;
            }
        }
    }
}
