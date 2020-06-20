using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort
{
    public static class GLOBAL
    {
        public static string username = "";
        public static string GetUsername(string user)
        {
            username = user;
            return username;
        }

        public static string grID = "0";
        public static string getID(string grid)
        {
            grID = grid;
            return grID;
        }
    }
}
