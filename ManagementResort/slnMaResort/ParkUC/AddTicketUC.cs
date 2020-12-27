using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using slnMaResort.BLL;
using slnMaResort.DAL;

namespace slnMaResort.ParkUC
{
    public partial class AddTicketUC : UserControl
    {
        public AddTicketUC()
        {
            InitializeComponent();
            TicketBLL.Instance.LoadPicTicket(flTicket);
        }
        MyPic myPic = new MyPic();
        PictureDAL pictureDAL = new PictureDAL();

        private void btEdit_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtIDTicket.Text);
            string name = txtName.Text;
            float price = Convert.ToSingle(txtPrice.Text);
            int amount = Convert.ToInt32(numAvailable.Value);
            MemoryStream pic = new MemoryStream();
            picTicket.Image.Save(pic, picTicket.Image.RawFormat);

            if (pictureDAL.updateTicker(idFood, name, price, pic, amount))
            {
                MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TicketBLL.Instance.LoadPicTicket(flTicket);
                TicketBLL.Instance.loadpicket(dgvTickets);
            }
            else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddTicketUC_Load(object sender, EventArgs e)
        {
            TicketBLL.Instance.loadpicket(dgvTickets);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtIDTicket.Text);
            string name = txtName.Text;
            float price = Convert.ToSingle(txtPrice.Text);
            int amount = Convert.ToInt32(numAvailable.Value);
            MemoryStream ms = new MemoryStream();
            picTicket.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();

            if (pictureDAL.insertTicket(idFood, name, price, ms, amount))
            {
                MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TicketBLL.Instance.LoadPicTicket(flTicket);
                TicketBLL.Instance.loadpicket(dgvTickets);
            }
            else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDTicket.Text);
            TicketBLL.Instance.deleteTicket(ID);
            TicketBLL.Instance.LoadPicTicket(flTicket);
            TicketBLL.Instance.loadpicket(dgvTickets);
        }

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvTickets.CurrentRow.Cells[0].Value);
            DataTable dt = TicketBLL.Instance.loadticketbyId(id);
            txtIDTicket.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtPrice.Text = dt.Rows[0][2].ToString();
            numAvailable.Text = dt.Rows[0][4].ToString();
            try
            {
                byte[] picPD;
                picPD = (byte[])dt.Rows[0][3];
                MemoryStream pic = new MemoryStream(picPD);
                this.picTicket.Image = Image.FromStream(pic);
                //picTicket.
            }
            catch
            { }
        }

        private void btUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picTicket.Image = Image.FromFile(open.FileName);
        }
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
    }
}
