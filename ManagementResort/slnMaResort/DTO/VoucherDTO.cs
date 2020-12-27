using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnMaResort.BLL;
namespace slnMaResort.DTO
{
    class VoucherDTO : abObser
    {

        private string name;
        List<EmployeeDTO> listemployee = new List<EmployeeDTO>();

        public string Name { get => name; set => name = value; }
        public override void ObserverInfo(string info)
        {
            foreach (EmployeeDTO item in listemployee)
            {
                if (item != null)
                {
                    item.ObserverInfo(name);
                }
            }
        }
        public void addemp(EmployeeDTO emp)
        {
            if (emp != null)
            {
                listemployee.Add(emp);
            }
        }
        public VoucherDTO(string name)
        {
            this.Name = name;
        }
        public void updateVou(int ID, int Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherBLL.Instance.updateVou(ID, Area, Name, StartDate, Expriration, Percents);
        }
        public void insertVou(int ID, int Area, string Name, DateTime StartDate, DateTime Expriration, int Percents)
        {
            VoucherBLL.Instance.insertVou(ID, Area, Name, StartDate, Expriration, Percents);
        }
    }
}
