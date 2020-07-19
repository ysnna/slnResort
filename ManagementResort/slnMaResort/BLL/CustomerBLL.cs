using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.BLL
{
    class CustomerBLL
    {
        private static CustomerBLL instance;
        private CustomerBLL() { }
        public static CustomerBLL Instance
        {
            get
            {
                if (instance == null) instance = new CustomerBLL();
                return CustomerBLL.instance;
            }
            private set => CustomerBLL.instance = value;
        }
        public DataTable createIDCustomer()
        {
            DataTable dt = CustomerDAL.Instance.createIDCustomer();
            return dt;
        }
         
        public void insertCustomerRoom(string idCustomer, string idRoom)
        {
            CustomerDAL.Instance.insertCustomerRoom(idCustomer, idRoom);
        }

        public void insertCustomer(string IDCustomer, string name, DateTime birthday, string gender, string phone, string IDCard)
        {
            CustomerDAL.Instance.insertCustomer(IDCustomer, name, birthday, gender, phone, IDCard);
        }
    }
}
