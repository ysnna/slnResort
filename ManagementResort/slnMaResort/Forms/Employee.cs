using slnMaResort.HomeUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.Forms
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            var ucEmployee = new ucEmployee();
            this.Controls.Add(ucEmployee);
            
            
        }
    }
}
