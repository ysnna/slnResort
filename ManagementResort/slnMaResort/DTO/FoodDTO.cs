using System;
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

        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Image picture { get; set; }

        public static int width = 300;
        public static int height = 250;
        public FoodDTO(float PRICE,string NAME,Image Picture)
        {
            this.Price = PRICE;
            this.Name = NAME;
            this.picture = Picture;
        }

        public FoodDTO(DataRow row)
        {
            this.Name = row["Name"].ToString();
            this.Price = float.Parse(row["Price"].ToString());


            //byte[] picPD;
            //picPD = (byte[])row["Picture"];
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picture = Image.FromStream(pic);

        }
       
    }
}
