using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    class RoomDTO
    {
        public string ID { get; set; }
        public string Price { get; set; }
        public string State { get; set; }
        public static int width = 210;
        public static int height = 229;
        public static string IDRoomSelected = "";

        public RoomDTO(string id, string state)
        {
            this.ID = id;
            this.State = state;
        }
        public RoomDTO(DataRow row)
        {
            this.ID = row["IDRoom"].ToString();
            this.State = row["State"].ToString();
        }
    }
}
