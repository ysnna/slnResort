using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace slnMaResort.DAL
{
    public class EmployeeDAL
    {
        private static EmployeeDAL instance;
        private EmployeeDAL() { }
        public static EmployeeDAL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAL();
                return EmployeeDAL.instance;
            }
            private set => EmployeeDAL.instance = value;
        }
    }
}
