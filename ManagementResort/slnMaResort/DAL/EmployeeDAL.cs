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

        public DataTable loadEmp()
        {
            string sql = @"EXEC LOADEMPLOYEE";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }


        public DataTable loadEmpbyID(string id)
        {
            string sql = @"EXEC CHECKLOGIN  '" + id + "' ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
