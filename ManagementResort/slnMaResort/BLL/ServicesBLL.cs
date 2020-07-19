using slnMaResort.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.BLL
{
    class ServicesBLL
    {
        private static ServicesBLL instance;
        private ServicesBLL() { }
        public static ServicesBLL Instance
        {
            get
            {
                if (instance == null) instance = new ServicesBLL();
                return ServicesBLL.instance;
            }
            private set => ServicesBLL.instance = value;
        }
        public void loadServices(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.RowTemplate.Height = 40;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = ServicesDAL.Instance.loadServices();
            dgv.DataSource = dt;
        }
    }
}
