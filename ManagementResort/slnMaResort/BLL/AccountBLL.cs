using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using slnMaResort.DAL;
using slnMaResort.DTO;
using slnMaResort.Forms;
using System.Windows.Forms;


namespace slnMaResort.BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;
        private AccountBLL() { }
        public static AccountBLL Instance
        {
            get
            {
                if (instance == null) instance = new AccountBLL();
                return AccountBLL.instance;
            }
            private set => AccountBLL.instance = value;
        }
        //Xac nhan giao dien cua user để chuyển
        //public string DefinePass(string usr)
        //{
        //    DataTable dt = new DataTable();
        //    dt = AccountDAL.Instance.loadPermission(usr);
        //    string dtpass = dt.Rows[0][0].ToString();
        //    return dtpass;
        //}


        public bool DefinePass(string pass, string usr )
        {
            DataTable dt = new DataTable();
            dt = AccountDAL.Instance.loadPermission(usr);
            if (dt.Rows.Count > 0)
            {
                string dtpass = dt.Rows[0][0].ToString();
                if (pass == dtpass)
                    return true;
            }
            return false;
        }
        public string DefineState(string usr)
        {
            string state = "";
            DataTable dt = new DataTable();
            dt = AccountDAL.Instance.loadPermission(usr);
            if (dt.Rows.Count > 0)
            {
                state = dt.Rows[0][1].ToString().Trim();
                return state;
            }
            else return state;         
        }
        public string DefineGroup(string usr)
        {
            string group="";
            DataTable dt = new DataTable();
            dt = AccountDAL.Instance.CheckPer(usr);
            if (dt.Rows.Count > 0)
            {
                group = dt.Rows[0][0].ToString().Trim();
                
                return group;
            }
            else return group;
        }
        public void callForm(string usr)
        {
            
            string group = DefineGroup(usr);
            
            switch (group)
            {
                case "GROUPAD":
                    {
                        //HomeForm f = new HomeForm();
                        Employee f = new Employee();
                        f.ShowDialog();
                        
                        break;
                    }
                case "GROUPMH":
                    {
                        MHotelForm f = new MHotelForm();
                        f.ShowDialog();
                        break;
                    }
                case "GROUPMR":
                    {
                        MRestaurantForm f = new MRestaurantForm();
                        f.ShowDialog();
                        break;
                    }
                case "GROUPMP":
                    {
                        MAmusementParkForm f = new MAmusementParkForm();
                        f.ShowDialog();
                        break;
                    }
            }
        }
        //Doi password
        #region ChangePass
        public void changePass(string oldpass, string newpass, string comfirm)
        {
            if (AccountBLL.Instance.DefinePass(oldpass, GLOBAL.username))
            {
                if (newpass == comfirm)
                {
                    AccountDAL.Instance.UpdatePass(GLOBAL.username,newpass);
                }
                else { MessageBox.Show("Your new pass and comfirm pass are not the same"); }
            }
            else
            {
                MessageBox.Show("Wrong pass");
            }
        }

        #endregion
    }
}
