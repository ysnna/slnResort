using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class ServicesDAL
    {
        private static ServicesDAL instance;
        private ServicesDAL() { }
        public static ServicesDAL Instance
        {
            get
            {
                if (instance == null) instance = new ServicesDAL();
                return ServicesDAL.instance;
            }
            private set => ServicesDAL.instance = value;
        }
        public DataTable loadServices()
        {
            string sql = @"EXEC LOADSERVICE ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
