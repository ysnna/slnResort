using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class PictureDAL
    {
        MyPic myPic = new MyPic();
        public bool updateMenuFood(int id, string name,  float price, string description, MemoryStream pic, int amount)
        {
            SqlCommand cmd = new SqlCommand("insert into MENUFOOD set Name=@name, Picture=@pic, Price=@price, Description=@des, Available=@amt where IDFood=@id", myPic.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myPic.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                myPic.closeConnection();
                return true;
            }
            else
            {
                myPic.closeConnection();
                return false;
            }
        }
        public bool insertFood(int id, string name,  string description,float price, MemoryStream pic, int amount)
        {
            SqlCommand cmd = new SqlCommand("insert into MENUFOOD(IDFood,Name,Price,Description,Picture,Available) values(@id,@name,@price,@des,@pic,@amt)", myPic.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myPic.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                myPic.closeConnection();
                return true;
            }
            else
            {
                myPic.closeConnection();
                return false;
            }
        }

        public bool insertTicket(int id, string name, float price,  MemoryStream pic, int amount)
        {
            SqlCommand cmd = new SqlCommand("insert into TICKETBOOKING set Name = @name,, Price = @price, Picture = @pic, Available = @amt where IDTicketbooking = @id", myPic.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myPic.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                myPic.closeConnection();
                return true;
            }
            else
            {
                myPic.closeConnection();
                return false;
            }
        }

        public bool updateTicker(int id, string name, float price, MemoryStream pic, int amount)
        {
            SqlCommand cmd = new SqlCommand("update TICKETBOOKING set Name=@name, Picture=@pic, Price=@price, Available=@amt where IDTicketbooking=@id", myPic.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = price;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myPic.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                myPic.closeConnection();
                return true;
            }
            else
            {
                myPic.closeConnection();
                return false;
            }
        }
    }
}
