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

        public DataTable loadListRoom()
        {
            string sql = @"EXEC LOADALLROOM ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable searchPriceRoom(string ID)
        {
            string sql = @"EXEC SEARCHPRICEROOM '" + ID + "'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public DataTable searchCustomer(string id)
        {
            string sql = @"EXEC SELECTCUSTOMERFORROOM '" + id + "'";
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

        public DataTable loadServiceAvailable(string idRoom)
        {
            string sql = @"EXEC SELECTSERVICEAVAILABLE '" + idRoom + "'";
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

        public void updateServiceState(string idRoom, int idService, string state)
        {
            string sql = @"EXEC UPDATESTATESERVICEROOM '" + idRoom + "','" + idService + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void insertBookRoom(string idCard, string idRoom, DateTime dateBooked, DateTime dateCheckin, DateTime dateCheckOut, string state)
        {
            string sql = @"EXEC INSERTBOOKROOM '" + idCard + "','" + idRoom + "','" + dateBooked + "','" + dateCheckin + "','" + dateCheckOut + "','" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public DataTable loadBooked()
        {
            string sql = @"EXEC LOADBOOKROOM ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
