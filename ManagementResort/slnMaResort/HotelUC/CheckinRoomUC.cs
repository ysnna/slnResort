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
        string IDCustomer = "";

        private void CheckinRoomUC_Load(object sender, EventArgs e)
        {
            dtpDateBooked.Value = DateTime.Now;
            dtpTimeBooked.Value = DateTime.Now;
            DataTable dt = CustomerBLL.Instance.createIDCustomer();
            IDCustomer = dt.Rows[0][0].ToString();
            txtIDCustomer.Text = IDCustomer;
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
                listBookRoom = new BookRoomDTO();
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
                getListBookRoom.Add(listBookRoom);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            refreshInfo();
        }

        void refreshInfo()
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
            getListServices.Add(listServices);
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
            DataTable dt = RoomBLL.Instance.searchCustomer(id);
            txtIDRoom.Text = id;

            if (state == "Full")
            {
                btAddServices.Enabled = true;
                btCheckin.Enabled = false;
                txtidInvoice.Visible = false;
                btAdd.Enabled = false;
                txtIDCustomer.Text = dt.Rows[0][0].ToString();
                txtName.Text = dt.Rows[0][1].ToString();
                txtPhone.Text = dt.Rows[0][4].ToString();
                txtIDCard.Text = dt.Rows[0][5].ToString();
                //dtpBirthday.Value = Convert.ToDateTime(dt.Rows[0][2]);
                radMale.Checked = true;
                //int gender = Convert.ToInt32(dt.Rows[0][3].ToString());
                //if (gender == 1) radFemale.Checked = true;
                //else radMale.Checked = true;
                dtpDateCheckin.Value = Convert.ToDateTime(dt.Rows[0][6].ToString());
                dtpTimeCheckin.Value = Convert.ToDateTime(dt.Rows[0][6].ToString());
                dtpDateCheckout.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
                dtpTimeCheckout.Value = Convert.ToDateTime(dt.Rows[0][7].ToString());
            }
            else
            {
                btAddServices.Enabled = false;
                btCheckin.Enabled = true;
                txtidInvoice.Visible = true;
                txtIDCustomer.Text = IDCustomer;
                if (state == "Empty")
                {
                    btAdd.Enabled = true;
                    dtpDateCheckin.Value = DateTime.Now;
                    dtpTimeCheckin.Value = DateTime.Now;
                    dtpDateBooked.Value = DateTime.Now;
                    dtpTimeBooked.Value = DateTime.Now;
                    string checkout = dtpDateCheckout.Value.ToShortDateString() + " " + dtpTimeCheckout.Value.ToShortTimeString();
                    listBookRoom = new BookRoomDTO();
                    listBookRoom.IDRoom = txtIDRoom.Text;
                    listBookRoom.DateBooked = DateTime.Now;
                    listBookRoom.DateCheckin = listBookRoom.DateBooked;
                    listBookRoom.DateCheckout = Convert.ToDateTime(checkout);
                    listBookRoom.Price = Convert.ToDouble(dgvListRoom.CurrentRow.Cells[4].Value.ToString());
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            dgvCheckin.Rows.Add(listBookRoom.IDRoom, listBookRoom.DateBooked, listBookRoom.DateCheckin, listBookRoom.DateCheckout, listBookRoom.Price);
            getListBookRoom.Add(listBookRoom);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RoomBLL.Instance.loadBooked(dgvBooked);
            RoomBLL.Instance.loadListRoom(dgvListRoom);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int count = dgvCheckin.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                dgvCheckin.Rows.RemoveAt(dgvCheckin.CurrentRow.Index);
                getListBookRoom.Remove(listBookRoom);
            }
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            string gender = "true";
            if (radMale.Checked == true) gender = "false";
            DateTime birthday = Convert.ToDateTime(dtpBirthday.Value.ToShortDateString());
            CustomerBLL.Instance.insertCustomer(IDCustomer, txtName.Text, birthday, gender, txtPhone.Text, txtIDCard.Text);
            InvoiceBLL.Instance.insertInvoice(txtidInvoice.Text, IDCustomer, "NV0001", "Room", DateTime.Now, 0, 0, 0, 0, 0, "NotPayment");

            int countRoom = getListBookRoom.Count;
            int countService = getListServices.Count;

            if (countRoom > 0)
            {
                for (int i = 0; i < countRoom; i++)
                {
                    InvoiceBLL.Instance.insertDetailInvoiceRoom(txtidInvoice.Text, getListBookRoom[i].IDRoom, getListBookRoom[i].DateBooked, getListBookRoom[i].DateCheckout, getListBookRoom[i].DateCheckout, Convert.ToSingle(getListBookRoom[i].Price));
                    RoomBLL.Instance.updateStateRoom(getListBookRoom[i].IDRoom, "Full");
                    CustomerBLL.Instance.insertCustomerRoom(IDCustomer, getListBookRoom[i].IDRoom);
                }
                for (int i = 0; i < countRoom; i++)
                {
                    dgvCheckin.Rows.RemoveAt(dgvCheckin.CurrentRow.Index);
                    getListBookRoom.Remove(listBookRoom);
                }
                MessageBox.Show("Đặt phòng thành công");
            }

            if (countService > 0)
            {
                DataTable ivc = InvoiceBLL.Instance.createIDInvoice();
                string idInvoice = ivc.Rows[0][0].ToString();
                InvoiceBLL.Instance.insertInvoice(idInvoice, IDCustomer, "NV0001", "Service", DateTime.Now, 0, 0, 0, 0, 0, "NotPayment");
                for (int i = 0; i < countService; i++)
                {
                    InvoiceBLL.Instance.insertDetailInvoiceService(idInvoice, getListServices[i].IDService, getListServices[i].Available, Convert.ToSingle(getListServices[i].Price));
                }
                for (int i = 0; i < countService; i++)
                {
                    dgvBookServices.Rows.RemoveAt(dgvBookServices.CurrentRow.Index);
                    getListServices.Remove(listServices);
                }
                MessageBox.Show("Đặt dịch vụ thành công");
            }
            refreshPage();
        }

        void refreshPage()
        {
            DataTable ivcNew = InvoiceBLL.Instance.createIDInvoice();
            txtidInvoice.Text = ivcNew.Rows[0][0].ToString();
            DataTable idCustomerNew = CustomerBLL.Instance.createIDCustomer();
            txtIDCustomer.Text = idCustomerNew.Rows[0][0].ToString();
            IDCustomer = txtIDCustomer.Text;
            refreshInfo();
            RoomBLL.Instance.loadBooked(dgvBooked);
            RoomBLL.Instance.loadListRoom(dgvListRoom);
        }
    }
}