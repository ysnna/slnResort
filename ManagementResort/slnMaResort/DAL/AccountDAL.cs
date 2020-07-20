using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using slnMaResort.DTO;

namespace slnMaResort.DAL
{
    class AccountDAL
    {
        private static AccountDAL instance;
        private AccountDAL() { }
        public static AccountDAL Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAL();
                return AccountDAL.instance;
            }
            private set => AccountDAL.instance = value;
        }
        
        public DataTable loadPermission(string usr)
        {
            string sql = @"EXEC CHECKLOGIN '" + usr + "' ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable CheckPer(string user)
        {
            string sql = @"exec CHECKGROUP '" + user + "'";
            MY_DB.Instance.executeQuery(sql);
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable getEmpID(string user)
        {
            string sql = @"exec getEmpID '" + user + "'";
            MY_DB.Instance.executeQuery(sql);
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        // Doi pass word -- chua viet ham stored
        public void UpdatePass(string usr,string pass)
        {
            string sql = @"exec CHANGEPASSWORD '" + usr + "' "+pass+"'";
            MY_DB.Instance.executeQuery(sql);      
        }


    }
}
