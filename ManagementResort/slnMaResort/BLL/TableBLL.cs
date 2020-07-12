using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.BLL
{
    public class TableBLL
    {
        private static TableBLL instance;
        private TableBLL() { }
        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return TableBLL.instance;
            }
            private set => TableBLL.instance = value;
        }
    }
}
