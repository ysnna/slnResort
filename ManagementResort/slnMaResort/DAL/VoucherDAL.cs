using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace slnMaResort.DAL
{
    public class VoucherDAL
    {
        private static VoucherDAL instance;
        private VoucherDAL() { }
        public static VoucherDAL Instance
        {
            get
            {
                if (instance == null) instance = new VoucherDAL();
                return VoucherDAL.instance;
            }
            private set => VoucherDAL.instance = value;
        }
        public DataTable loadVoucher()
        {
            string sql = @"EXEC LOADVOUCHER";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

        public void insertVou(int ID, string Area,string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            string sql = @"EXEC INSERTVOUCHER '" + ID + "'" + Area + "'" + Name + "'" + StartDate
                + "'" + Expriration + "'" + Percents + "'";
              
            MY_DB.Instance.executeQuery(sql);
        }

        public void deleteVou(int ID)
        {
            string sql = @"EXEC DELETEVOUCHER" + ID + "'";
            MY_DB.Instance.executeQuery(sql);
        }
    }
}
