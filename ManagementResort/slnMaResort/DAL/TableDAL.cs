using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace slnMaResort.DAL
{
    public class TableDAL
    {
        private static TableDAL instance;
        private TableDAL() { }
        public static TableDAL Instance
        {
            get
            {
                if (instance == null) instance = new TableDAL();
                return TableDAL.instance;
            }
            private set => TableDAL.instance = value;
        }
        public DataTable loadTable()
        {
            string sql = @"exec LOADTABLES  ";
            MY_DB.Instance.executeQuery(sql);
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
