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
            pict.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvMenu.Columns.Add(pict);

            dgvMenu.RowTemplate.Height = 250;

            dgvMenu.AllowUserToAddRows = false;




            int index = dgvMenu.CurrentCell.RowIndex;
            int id =    int.Parse(dgvMenu.Rows[index].Cells[0].Value.ToString());
            txtIDFood.Text = id.ToString();
            DataTable dt = FoodBLL.Instance.loadfoodbyid(id);


            byte[] picPD;
            picPD = (byte[])dgvMenu.Rows[index].Cells[4].Value;
            MemoryStream pic = new MemoryStream(picPD);
            this.picFood.Image = Image.FromStream(pic);

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
            //MemoryStream strm = new MemoryStream();
            //if (strFilePath == "")
            //{
            //    if (ImageByteArray.Length != 0)
            //        ImageByteArray = new byte[] { };
            //}
            //else
            //{
            //    Image temp = new Bitmap(strFilePath);
            //    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    ImageByteArray = strm.ToArray();
            //}


            MemoryStream picture = new MemoryStream();
          
            picFood.Image.Save(picture, picFood.Image.RawFormat);
            byte[] img = picture.ToArray();
            dgvMenu.Rows.Add(img);
            FoodBLL.Instance.insertFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text,picture
                ,int.Parse( numAvailable.Value.ToString()));
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MemoryStream picture = new MemoryStream();

            picFood.Image.Save(picture, picFood.Image.RawFormat);

            FoodDAL.Instance.updateFood(int.Parse(txtIDFood.Text),
                txtNameFood.Text,
                int.Parse(txtPrice.Text),
                txtDescriptions.Text, picture
                , int.Parse(numAvailable.Value.ToString()));
        }
    }
}
