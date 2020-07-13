using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using slnMaResort.DAL;
using slnMaResort.DTO;
using slnMaResort.Forms;

namespace slnMaResort.BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;
        private EmployeeBLL() { }
        public static EmployeeBLL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeBLL();
                return EmployeeBLL.instance;
            }
            private set => EmployeeBLL.instance = value;
        }

    }
}
