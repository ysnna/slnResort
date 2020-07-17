using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public DataTable loadTables()
        {
            string sql = @"EXEC LOADMENUFOODNOTDESCRIPTION ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable loadDesciptionID(int ID)
        {
            string sql = @"EXEC SEARCHMENUFOODDESCRIPTIONBYID '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
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

        public DataTable loadTableBookTable()
        {
            string sql = @"exec LOADBOOKTABLE  ";
            MY_DB.Instance.executeQuery(sql);
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable searchMemberByPhone(string phone)
        {
            string sql = @"EXEC SEARCHCUSTOMERBOOKTABLES '" + phone + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable searchIDTable(int id)
        {
            string sql = @"EXEC SEARCHPHONEBOOKTABLES '" + id + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable searchIDTableEmpty(int id)
        {
            string sql = @"EXEC SEARCHIDTABLES '" + id + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public void insertBookTable(int idTable, string phone, DateTime dateBook, DateTime dateCheckin, string state)
        {
            string sql = @"EXEC INSERTBOOKTABLE '" + idTable + "','" + phone + "','" + dateBook + "','" + dateCheckin
                + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}
