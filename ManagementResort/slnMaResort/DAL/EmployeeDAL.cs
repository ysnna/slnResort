using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace slnMaResort.DAL
{
    public class EmployeeDAL
    {
        private static EmployeeDAL instance;
        private EmployeeDAL() { }
        public static EmployeeDAL Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAL();
                return EmployeeDAL.instance;
            }
            private set => EmployeeDAL.instance = value;
        }
        //Load tất cả nhân viên
        public DataTable loadEmp()
        {
            string sql = @"EXEC LOADEMPLOYEE";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        //Load nhân viên theo Khu Vuc
        public DataTable loadEmpbyArea(int area)
        {
            string sql = @"EXEC LOADEMPOYEETOAREA '"+area+"'";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
       
        public DataTable loadEmpbyID(string id)
        {
            string sql = @"EXEC LOADEMPLOYEEINFO  '" + id + "' ";
            DataTable dt = MY_DB.Instance.createTable(sql);
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public void insertEmployee(string ID, string fullName, MemoryStream ava, DateTime birthday, int Gender,string add, string idcard,string phone,
           int IDBaseSalary, int Area, string state) 
        {
            string sql = @"EXEC INSERTEMPLOYEE '"+ID+"'"+fullName+"'"+ava+"'"+birthday+"'"+Gender+"'"+add+"'"
                +idcard+"'"+phone+"'"+IDBaseSalary+"'"+Area+"'"+state+"'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void updateEmployee(string ID, string fullName, MemoryStream ava, DateTime birthday, int Gender, string add, string idcard, string phone,
          int IDBaseSalary, int Area, string state)
        {
            string sql = @"EXEC UPDATEEMPLOYEE '" + ID + "'" + fullName + "'" + ava + "'" + birthday + "'" + Gender + "'" + add + "'"
                + idcard + "'" + phone + "'" + IDBaseSalary + "'" + Area + "'" + state + "'";
            MY_DB.Instance.executeQuery(sql);
        }

        public void deleteEmployee(string ID)
        {
            string sql = @"EXEC DELETEEMPLOYEE '" + ID + "'";
            MY_DB.Instance.executeQuery(sql);
        }
        public void loadIDAREAEMP()
        {
            string sql = "Select * From AREA, EMPLOYEE Where AREA.IDArea = EMPLOYEE.IDArea";
            MY_DB.Instance.executeQuery(sql);
        }

    }
}
