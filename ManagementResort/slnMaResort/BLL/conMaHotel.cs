using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnMaResort.DAL;
using slnMaResort.DTO;
namespace slnMaResort.BLL
{

    public class conMaHotel : abManager
    {
        public override IEmployee CallEmployee()
        {
            return conCreateHotelEmp.Instance;
        }
    }
}
