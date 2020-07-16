using slnMaResort.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    public abstract class abManager
    {
        public abstract IEmployee CallEmployee();

        public DataTable SomeOperation()
        {
            DataTable dt = CallEmployee().loadEmployee();
            return dt;
        }

    }
}
