using slnMaResort.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    abstract class abManager
    {
        public abstract IEmployee CallEmployee();

        public void SomeOperation()
        {
            // Call the factory method to create a Product object.
            //var product = CallEmployee();
            //int ID;
            //var result = product.deleteEmployee(ID);
        }

    }
}
