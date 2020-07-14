using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort
{
    class table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime rentTime { get; set; }
        public double RemainTime { get; set; }
        public Stopwatch stopwatch = new Stopwatch();
        public static int TableWidth = 200;
        public static int tableHeight = 200;
        public int remainTemp = 0;

        public table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public table(DataRow row)
        {
            this.Id = Convert.ToInt16(row["id"]);
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
            this.rentTime = Convert.ToDateTime(row["rentTime"]);
        }
    }
}
