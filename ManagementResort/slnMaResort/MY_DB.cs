using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace slnMaResort
{
    public class MY_DB
    {   //Danh connection
        //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\DANH;Initial Catalog=ManagementResort;Integrated Security=True");
        //Na connection
        //  SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAAGMFB\NNA;Initial Catalog=ManagementResort;Integrated Security=True");
        //Duc connection
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ManagementResort;Integrated Security=True");

        //Vuong connection

        private static MY_DB instance;
        private MY_DB() { }
        public static MY_DB Instance
        {
            get
            {
                if (instance == null) instance = new MY_DB();
                return MY_DB.instance;
            }
            private set => MY_DB.instance = value;
        }
        public SqlConnection getConnection
        {
            get { return conn; }
        }
        public void openConnection()
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if ((conn.State == ConnectionState.Open))
            {
                conn.Close();
                //conn.Dispose();
            }
        }
        public DataTable createTable(String sql)
        {
            openConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, getConnection);
            DataSet dt = new DataSet();
            da.Fill(dt);
            closeConnection();
            return dt.Tables[0];
        }
        public void executeQuery(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            openConnection();
            try
            {
                cmd.Connection = getConnection;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                closeConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
