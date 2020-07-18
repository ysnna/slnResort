using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class RoomDAL
    {
        private static RoomDAL instance;
        private RoomDAL() { }
        public static RoomDAL Instance
        {
            get
            {
                if (instance == null) instance = new RoomDAL();
                return RoomDAL.instance;
            }
            private set => RoomDAL.instance = value;
        }
        public DataTable loadRoom()
        {
            string sql = @"EXEC LOADROOMSNOTREQUIMENT ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable loadRequimentID(string ID)
        {
            string sql = @"EXEC SEARCHROOMREQUIMENTBYID '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable searchStateRoom(string state)
        {
            string sql = @"EXEC SELETESTATEROOM '" + state + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable searchIDcard(string IDCard)
        {
            string sql = @"EXEC SEARCHCUSTOMERBOOKROOM '" + IDCard + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable searchDataBookRoom(string ID)
        {
            string sql = @"EXEC SEARCHDATABOOKROOM '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable loadBooked()
        {
            string sql = @"EXEC LOADBOOKROOM ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public void insertBookRoom (string idCard, string idRoom, DateTime dateBooked, DateTime dateCheckin, DateTime dateCheckout,string state)
        {
            string sql = @"EXEC INSERTBOOKTABLE '" + idCard + "','" + idRoom + "','" + dateBooked + "','" + dateCheckin 
                + "','" + dateCheckout + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void updateStateRoom (string idRoom, string state)
        {
            string sql = @"EXEC UPDATESTATEROOM '" + idRoom + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void updateStateBookRoom (string idRoom, string state)
        {
            string sql = @"EXEC UPDATESTATEBOOKROOM '" + idRoom + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void deleteBookRoom (string idRoom)
        {
            string sql = @"EXEC DELETEBOOKROOM '" + idRoom + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}
