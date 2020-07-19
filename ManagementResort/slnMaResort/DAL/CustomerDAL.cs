using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class CustomerDAL
    {
        private static CustomerDAL instance;
        private CustomerDAL() { }
        public static CustomerDAL Instance
        {
            get
            {
                if (instance == null) instance = new CustomerDAL();
                return CustomerDAL.instance;
            }
            private set => CustomerDAL.instance = value;
        }
        public DataTable createIDCustomer()
        {
            string sql = @"EXEC AUTOINCREMENTCUSTOMER ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
