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
        public DataTable searchCheckinTime(int id)
        {
            string sql = @"exec SEARCHCHECKINBOOKTABLE '" + id + "'";
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

        public void updateTable(int idTable, string state)
        {
            string sql = @"EXEC UPDATESTATETABLES '" + idTable + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public DataTable loadDetailsInvoiceFood(int id)
        {
            string sql = @"EXEC SEARCHCUSTOMERANDINVOICEINTABLE '" + id + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        //Vương viết
        public void updateStateTables(int idTable, string state)
        {
            string sql = @"EXEC UPDATESTATETABLES '" + idTable + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void updateStateBookTable(int idTable, string state)
        {
            string sql = @"EXEC UPDATESTATEBOOKTABLE '" + idTable + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void deleteBookTable(int idTable)
        {
            string sql = @"EXEC DELETEBOOKTABLE '" + idTable + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}
