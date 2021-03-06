﻿using slnMaResort.DAL;
using slnMaResort.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.BLL
{
   public class FoodBLL
    {
        private static FoodBLL instance;
        private FoodBLL() { }
        public static FoodBLL Instance
        {
            get
            {
                if (instance == null) instance = new FoodBLL();
                return FoodBLL.instance;
            }
            private set => FoodBLL.instance = value;
        }

        void loadMenuFoody(DataGridView dgv) { }

        //load lên datagridview

        public void loadmenufood(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
           // pict = (DataGridViewImageColumn)dgv.Columns[4];
           // pict.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataTable dt = FoodDAL.Instance.loadMenuFood();
            dgv.DataSource = dt;
            
        }
        public DataTable loadfoodbyid(int id)
        {
            DataTable dt = FoodDAL.Instance.LoadFoodByID(id);
            return dt;
        }
        public void LoadFoody(FlowLayoutPanel flp)
        {
            List<FoodDTO> foodDTOs = new List<FoodDTO>();
            DataTable dt = new DataTable();
            dt = FoodDAL.Instance.loadMenuFood();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    FoodDTO foodDTO = new FoodDTO(item);
                    foodDTOs.Add(foodDTO);
                }
                foreach (FoodDTO item in foodDTOs)
                {
                    // 145, 221
                    Button bt = new Button()
                    {
                        Width = FoodDTO.width,
                        Height = FoodDTO.height
                    };
                    bt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);

                    bt.ForeColor = Color.Navy;
                    bt.BackColor = flp.BackColor;
                    bt.FlatAppearance.BorderColor = Color.Navy;
                    bt.FlatAppearance.BorderSize = 5;
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Text = item.Name.ToString();
                    bt.Text = item.Price.ToString();
                    flp.Controls.Add(bt);
                    flp.Refresh();
                }
            }

            
        }
        public void insertFood(int id,string name,int price,string description,MemoryStream pic,int available)
        {
            FoodDAL.Instance.insertFood(id, name, price, description, pic, available);
        }
    }
}
