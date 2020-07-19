using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    class BookRoomDTO
    {
        public string IDRoom { get; set; }
        public DateTime DateBooked { get; set; }
        public DateTime DateCheckin { get; set; }
        public DateTime DateCheckout { get; set; }
        public double Price { get; set; }

    }
}
