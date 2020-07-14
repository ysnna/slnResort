using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.BLL
{
    public class FoodBLL
    {
        private static FoodBLL instance;
        private FoodBLL() { }
        public static FoodBLL Instance
        {
            get
            {
                if (instance == null) instance = new FoodBLL();
                return FoodBLL.instance;
            }
            private set => FoodBLL.instance = value;
        }


    }
}
