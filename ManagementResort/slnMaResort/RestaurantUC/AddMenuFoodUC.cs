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
using System.IO;
using System.Net.NetworkInformation;

namespace slnMaResort.RestaurantUC
{
    public partial class AddMenuFoodUC : UserControl
    {
        String strFilePath = "";
        Byte[] ImageByteArray;
        public AddMenuFoodUC()
        {
            InitializeComponent();
            
        }

        private void AddMenuFoodUC_Load(object sender, EventArgs e)
        {
            

            FoodBLL.Instance.loadmenufood(dgvMenu);
            FoodBLL.Instance.LoadFoody(flFood);
        }

        private void gbs_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] ImageData = null;

            int id;

            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
            txtIDFood.Text = dt.Rows[0][0].ToString();
            txtNameFood.Text = dt.Rows[0][1].ToString();
            txtPrice.Text = dt.Rows[0][2].ToString();
            txtDescriptions.Text = dt.Rows[0][3].ToString();
//            MemoryStream pic = new MemoryStream((byte[])dt.Rows[0][4]);
//            this.picFood.Image = Image.FromStream(pic);
//            if (!Convert.IsDBNull(dt.Rows[0][4]))
//            {
//                picFood= (byte[])dt.Rows[0][4]);
//            }

//            if (dt.Rows[0][4] != System.DBNull.Value)
//{
//                byte[] imgg = (byte[])(dt.Rows[0][4]);
//                picFood.Image = de;
//            }


        }

        private void btUploadImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                strFilePath = open.FileName;
                picFood.Image = Image.FromFile(open.FileName);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            byte[] ImageData = null;
            ImageData = imgToByteArray(picFood.Image);
            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text,ImageData
                ,int.Parse( numAvailable.Value.ToString()));
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            byte[] ImageData = null;
            ImageData = imgToByteArray(picFood.Image);
            FoodDAL.Instance.updateFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text, ImageData
                , int.Parse(numAvailable.Value.ToString()));
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
