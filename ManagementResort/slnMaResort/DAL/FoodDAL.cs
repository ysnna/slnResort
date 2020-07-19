using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       //load tất cả thức ăn 
        public DataTable loadMenuFood()
        {
            string sql = @"EXEC LOADMENUFOOD";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;

        }
        public DataTable LoadFoodByID(int ID)
        {
            string sql = @"EXEC LOADFOODBYID '" + ID + "'"; ;
            DataTable dt = MY_DB.Instance.createTable(sql);
            return dt;
        }

        public void insertFood(int ID,string Name,int Price,string Des, MemoryStream Picture,int Available)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            string sql = @"EXEC INSERTFOOD'" + ID + "'" + Name + "'" + Price + "'" + Des + "'" + Picture + "'" + Available + "'";
=======
            string sql = @"EXEC INSERTFOOD'" + ID + "','" + Name + "','" + Price + "','" + Des + "','" + Picture + "','" + Available + "'";
>>>>>>> Stashed changes
=======
            string sql = @"EXEC INSERTFOOD'" + ID + "','" + Name + "','" + Price + "','" + Des + "','" + Picture + "','" + Available + "'";
>>>>>>> Stashed changes
            MY_DB.Instance.executeQuery(sql);
        }
        public void updateFood(int ID, string Name, int Price, string Des, MemoryStream Picture, int Available)
        {
            string sql = @"EXEC UPDATEFOOD'" + ID + "'" + Name + "'" + Price + "'" + Des + "'" + Picture + "'" + Available + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void deleteFood(int ID)
        {
            string sql = @"EXEC DELETEFOOD'" + ID + "'";
            MY_DB.Instance.executeQuery(sql);
        }


    }
}
