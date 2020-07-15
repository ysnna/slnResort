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
    }
}
