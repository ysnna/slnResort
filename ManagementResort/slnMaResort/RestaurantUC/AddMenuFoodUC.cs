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

        private void AddMenuFoodUC_Load(object sender, EventArgs e)
        {
            FoodBLL.Instance.loadmenufood(dgvMenu);
        }



        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
            txtIDFood.Text = dt.Rows[0][0].ToString();
            txtNameFood.Text = dt.Rows[0][1].ToString();
            txtPrice.Text = dt.Rows[0][2].ToString();
            txtDescriptions.Text = dt.Rows[0][3].ToString();
            //picFood.Image = dt.Rows[0][4].
=======
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
=======
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
>>>>>>> Stashed changes
                txtIDFood.Text = dt.Rows[0][0].ToString();
                txtNameFood.Text = dt.Rows[0][1].ToString();
                txtPrice.Text = dt.Rows[0][2].ToString();
                txtDescriptions.Text = dt.Rows[0][3].ToString();         
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
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

        private void btUploadImage_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picFood.Image = Image.FromFile(open.FileName);
        }
=======
=======
>>>>>>> Stashed changes

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picFood.Image = Image.FromFile(open.FileName);
            }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes

        }
       
        private void btAdd_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            MemoryStream picture = new MemoryStream();
            try
            {
                picFood.Image.Save(picture, picFood.Image.RawFormat);
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Please insert an Avatar");
            }
            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text,
                picture,int.Parse( numAvailable.Value.ToString()));
        }
=======
            MemoryStream ms = new MemoryStream();
            picFood.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();

            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
=======
            MemoryStream ms = new MemoryStream();
            picFood.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();

            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
>>>>>>> Stashed changes
                txtDescriptions.Text,ms
                , int.Parse( numAvailable.Value.ToString()));
        }

        private void btEdit_Click(object sender, EventArgs e)
        {


            MemoryStream ms = new MemoryStream();
            picFood.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = ms.ToArray();

            FoodDAL.Instance.updateFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text, ms
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDFood.Text);
            FoodBLL.Instance.deleteFood(ID);
        }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
