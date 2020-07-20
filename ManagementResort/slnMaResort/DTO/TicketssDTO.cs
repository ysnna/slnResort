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
    class TicketssDTO
    {
        private int _id;
        private Image _pic;
        
        public static int width = 300;
        public static int height = 250;
        public TicketssDTO(int Id, Image PICTURE)
        {
            this.ID = Id;
            this.Pic = PICTURE;
        }
        public TicketssDTO(DataRow row)
        {
            this.ID = Convert.ToInt32(row["IDTicketbooking"].ToString());
            byte[] picPD;
            picPD = (byte[])row["Picture"];
            MemoryStream pica = new MemoryStream(picPD);
            this.Pic = Image.FromStream(pica);
        }
        public int ID { get; set; }
        public Image Pic { get; set; }
    }
}
