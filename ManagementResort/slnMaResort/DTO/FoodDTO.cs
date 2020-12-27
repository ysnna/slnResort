﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    class FoodDTO
    {
        private int _idfood;
        private string _name;
        private int _price;
        private string _description;
        private Image _avata;
        private int _available;

        public static int width = 300;
        public static int height = 250;
        public FoodDTO(int PRICE, string NAME, Image PICTURE)
        {
            this.Price = PRICE;
            this.Name = NAME;
            this.Avata = PICTURE;
        }
        public FoodDTO(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Price = Convert.ToInt32(row["Price"]);
         //   byte[] picPD;
          //  picPD = (byte[])row["Picture"];
         //   MemoryStream pic = new MemoryStream(picPD);
       //     this.Avata = Image.FromStream(pic);
        }
        public int Idfood { get => _idfood; set => _idfood = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }
        public string Description { get => _description; set => _description = value; }
        public Image Avata { get; set; }
        public int Available { get => _available; set => _available = value; }
    }
}