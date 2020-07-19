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
using slnMaResort.DAL;
using System.IO;

namespace slnMaResort.RestaurantUC
{
    public partial class AddMenuFoodUC : UserControl
    {
        public AddMenuFoodUC()
        {
            InitializeComponent();
            FoodBLL.Instance.LoadFoody(flFood);
        }

        MyPic myPic = new MyPic();
        PictureDAL pictureDAL = new PictureDAL();

        private void btUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picFood.Image = Image.FromFile(open.FileName);
        }

        private void AddMenuFoodUC_Load(object sender, EventArgs e)
        {
            FoodBLL.Instance.loadmenufood(dgvMenu);
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
            txtIDFood.Text = dt.Rows[0][0].ToString();
            txtNameFood.Text = dt.Rows[0][1].ToString();
            txtPrice.Text = dt.Rows[0][2].ToString();
            txtDescriptions.Text = dt.Rows[0][3].ToString();
            //picFood.Image = dt.Rows[0][4].

            try
            {
                byte[] picPD;
                picPD = (byte[])dt.Rows[0][4];
                MemoryStream pic = new MemoryStream(picPD);
                this.picFood.Image = Image.FromStream(pic);
            }
            catch
            { }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtIDFood.Text);
            string name = txtNameFood.Text;
            float price = Convert.ToSingle(txtPrice.Text);
            string description = txtDescriptions.Text;
            int amount = Convert.ToInt32(numAvailable.Value);
            MemoryStream pic = new MemoryStream();
            picFood.Image.Save(pic, picFood.Image.RawFormat);

            if (pictureDAL.insertFood(idFood, name, description, price, pic, amount))
            {
                //loadServiceMachine();
                MessageBox.Show("Insert to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FoodBLL.Instance.loadmenufood(dgvMenu);
                FoodBLL.Instance.LoadFoody(flFood);
                //ClearFormAddMachine();
            }
            else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    

        private void btEdit_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();
            //picFood.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] pic = ms.ToArray();

            //FoodDAL.Instance.updateFood(int.Parse(txtIDFood.Text),
            //    txtNameFood.Text,
            //    int.Parse(txtPrice.Text),
            //    txtDescriptions.Text, ms
            //    , int.Parse(numAvailable.Value.ToString()));
            int idFood = Convert.ToInt32(txtIDFood.Text);
            string name = txtNameFood.Text;
            float price = Convert.ToSingle(txtPrice.Text);
            string description = txtDescriptions.Text;
            int amount =Convert.ToInt32(numAvailable.Value);
            MemoryStream pic = new MemoryStream();
            picFood.Image.Save(pic, picFood.Image.RawFormat);

            if (pictureDAL.updateMenuFood(idFood, name, price ,description, pic, amount))
            {
                //loadServiceMachine();
                MessageBox.Show("Update to database successful", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FoodBLL.Instance.loadmenufood(dgvMenu);
                FoodBLL.Instance.LoadFoody(flFood);
                //ClearFormAddMachine();
            }
            else MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDFood.Text);
            FoodBLL.Instance.deleteFood(ID);
            FoodBLL.Instance.loadmenufood(dgvMenu);
            FoodBLL.Instance.LoadFoody(flFood);
        }
    }
}
