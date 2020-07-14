using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace slnMaResort.DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        private FoodDAL() { }
        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return FoodDAL.instance;
            }
            private set => FoodDAL.instance = value;
        }
        public DataTable loadMenuFood()
        {
            string sql = @"EXEC LOADMENUFOOD";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
    }
}
