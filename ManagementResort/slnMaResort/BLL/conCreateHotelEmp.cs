using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnMaResort.BLL;
using slnMaResort.DAL;
using System.IO;
namespace slnMaResort.BLL
{
    //FACTORY METHOD
    class conCreateHotelEmp: IEmployee
    {
        public void insertEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
              , int Gender, string add, string idcard, string phone,
            int IDBaseSalary, int Area, string state)
        {
            EmployeeDAL.Instance.insertEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);
        }
        public void updateEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
           , int Gender, string add, string idcard, string phone,
         int IDBaseSalary, int Area, string state)
        {
            EmployeeDAL.Instance.updateEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);
        }
        public void deleteEmployee(string ID)
        {
            EmployeeDAL.Instance.deleteEmployee(ID);
        }
    }
