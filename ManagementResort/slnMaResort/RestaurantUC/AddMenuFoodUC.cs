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
using System.Data.SqlClient;

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
<<<<<<< Updated upstream
            FoodBLL.Instance.loadmenufood(dgvMenu);
=======
           FoodBLL.Instance.loadmenufood(dgvMenu);
            //FoodBLL.Instance.LoadFoody(flFood);
>>>>>>> Stashed changes
        }

        private void gbs_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< Updated upstream
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
=======

            //int id;
            //id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            //DataTable dt = FoodBLL.Instance.loadfoodbyid(id);
            //txtIDFood.Text = dt.Rows[0][0].ToString();
            //txtNameFood.Text = dt.Rows[0][1].ToString();
            //txtPrice.Text = dt.Rows[0][2].ToString();
            //txtDescriptions.Text = dt.Rows[0][3].ToString();           
            //MemoryStream pic = new MemoryStream((byte[])dt.Rows[0][4]);
            //this.picFood.Image = Image.FromStream(pic);

            dgvMenu.RowTemplate.Height = 40;
            dgvMenu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
            pict = (DataGridViewImageColumn)dgvMenu.Columns[4];
            pict.ImageLayout = DataGridViewImageCellLayout.Zoom;
            int index = dgvMenu.CurrentCell.RowIndex;
            int id = int.Parse(dgvMenu.Rows[index].Cells[0].Value.ToString());
            txtIDFood.Text = id.ToString();
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);

            if (dt.Rows.Count > 0)
            {

                txtIDFood.Text = dt.Rows[0][0].ToString();
                txtNameFood.Text = dt.Rows[0][1].ToString();
                txtPrice.Text = dt.Rows[0][2].ToString();
                txtDescriptions.Text = dt.Rows[0][3].ToString();

                byte[] bytes = (byte[])dgvMenu.Rows[0].Cells[4].Value;
                MemoryStream ms = new MemoryStream(bytes);
                picFood.Image = Image.FromStream(ms);

            }

>>>>>>> Stashed changes
        }

        private void btUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picFood.Image = Image.FromFile(open.FileName);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

             MemoryStream picture = new MemoryStream();
            //try
=======
            // MemoryStream strm = new MemoryStream();
            //if (strFilePath == "")
>>>>>>> Stashed changes
            //{
                picFood.Image.Save(picture, picFood.Image.RawFormat);
            byte[] a = picture.GetBuffer();
            //}
            //catch (Exception Exc)
            //{
            //    MessageBox.Show("Please insert an Avatar");
            //}
<<<<<<< Updated upstream
         
        
=======


            MemoryStream ms = new MemoryStream((byte[])dgvMenu.CurrentRow.Cells[4].Value‌​);
            picFood.Image = Image.FromStream(ms);
>>>>>>> Stashed changes

            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text,ms
                ,int.Parse( numAvailable.Value.ToString()));
        }
<<<<<<< Updated upstream
=======

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream picture = new MemoryStream();

            picFood.Image.Save(picture, picFood.Image.RawFormat);

            FoodBLL.Instance.updateFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text, picture
                , int.Parse(numAvailable.Value.ToString()));
            }
            catch (Exception E)
            {
                
            }
        }
>>>>>>> Stashed changes
    }
}
