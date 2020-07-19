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

        public void insertCustomer(string IDCustomer, string name, DateTime birthday, string gender, string phone, string IDCard)
        {
            string sql = @"EXEC INSERTCUSTOMER '" + IDCustomer + "','" + name + "','" + birthday + "','" + gender + "','" + phone + "','" + IDCard + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void insertCustomerRoom(string idCustomer, string idRoom)
        {
            string sql = @"EXEC INSERTCUSTOMERROOM '" + idCustomer + "','" + idRoom + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}