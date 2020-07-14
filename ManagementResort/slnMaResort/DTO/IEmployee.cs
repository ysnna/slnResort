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
    public interface IEmployee
    {
        void insertEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
            , int Gender, string add, string idcard, string phone,
          int IDBaseSalary, int Area, string state);

        // EmployeeDAL.Instance.insertEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);

        void updateEmp(string ID, string fullName, MemoryStream ava, DateTime birthday
           , int Gender, string add, string idcard, string phone,
         int IDBaseSalary, int Area, string state);

        void deleteEmployee(string ID);
            //EmployeeDAL.Instance.insertEmployee(ID, fullName, ava, birthday, Gender, add, idcard, phone, IDBaseSalary, Area, state);

    }
}
