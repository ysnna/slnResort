using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DAL
{
    class TableDAL
    {
        private static TableDAL instance;
        private TableDAL() { }
        public static TableDAL Instance
        {
            get
            {
                if (instance == null) instance = new TableDAL();
                return TableDAL.instance;
            }
            private set => TableDAL.instance = value;
        }
    }
}
