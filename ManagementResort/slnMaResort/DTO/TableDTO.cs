using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.DTO
{
    class TableDTO
    {
        public int ID { get; set; }
        public string Sate { get; set; }
        public static int width = 210;
        public static int height = 229;
        public TableDTO(int id, string state)
        {
            this.ID = id;
            this.Sate = state;
        }
        public TableDTO(DataRow row)
        {
            this.ID = Convert.ToInt32(row["IDTable"]);

        }
    }
}
