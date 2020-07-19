using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort
{
    class MyPic
    {

        //SqlConnection conn = new SqlConnection(@"Data Source=192.168.43.252,1433;Initial Catalog=DBMS;Persist Security Info=True;User ID=ysnna;Password=123456");
        // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAAGMFB\NNA;Initial Catalog=ManagementResort;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=ManagementResort;Integrated Security=True");

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
            }
        }
    }
}
