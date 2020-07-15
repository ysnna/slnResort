using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data;
using slnMaResort.BLL;
using slnMaResort.DAL;

namespace slnMaResort.DTO
{
    class EmployeeDTO 
    {

        private string _idEmp;
        private string _fullName;
        private Image _avatar;
        private DateTime _birthday;
        private int _gender;
        private string _addredd;
        private string _idcard;
        private string _phone;
        private int _salary;
        private int _idarea;
        private string _state;
        private string email;

        public string IdEmp { get => _idEmp; set => _idEmp = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public Image Avatar { get => _avatar; set => _avatar = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public int Gender { get => _gender; set => _gender = value; }
        public string Addredd { get => _addredd; set => _addredd = value; }
        public string Idcard { get => _idcard; set => _idcard = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public int Salary { get => _salary; set => _salary = value; }
        public int Idarea { get => _idarea; set => _idarea = value; }
        public string State { get => _state; set => _state = value; }
        public string Email { get => email; set => email = value; }

        //public override void ObserverInfo(string info,int area)
        //{
        //    DataTable dt = EmployeeDAL.Instance.loadEmpbyArea(area);
        //    if (dt.Rows.Count > 0)
        //    {
        //        sentmail(FullName, Email, info);
        //        MessageBox.Show("Đã gửi mail đến " + FullName + " về sản phẩm " + info);
        //    }

        //}
        //void sentmail(string _fullName,
        // Image _avatar,
        //DateTime _birthday,
        // int _gender,
        //string _addredd,
        // string _idcard,
        // string _phone,
        // int _salary,
        // int _idarea,
        // string _state,
        // string email)
        //{
        //    try
        //    {
        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;
        //        client.Timeout = 10000;
        //        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //        client.UseDefaultCredentials = false;
        //        client.Credentials = new NetworkCredential("17110108@gmail.com", "01225032233");
        //        MailMessage msg = new MailMessage();
        //        msg.To.Add(email);
        //        msg.From = new MailAddress("17110108@gmail.com");
        //        msg.Subject = "Thông tin về MÃ GIẢM GIÁ ưu đãi mới";
        //        msg.Body = "Thông báo đến : " + _fullName + "  Thông tin MÃ GIẢM GIÁ :   " + ;
        //        client.Send(msg);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //public EmployeeDTO(string _idEmp,
        //string _fullName,
        // Image _avatar,
        //DateTime _birthday,
        // int _gender,
        //string _addredd,
        // string _idcard,
        // string _phone,
        // int _salary,
        // int _idarea,
        // string _state,
        // string email)
        //{
        //    this.FullName = _fullName;
        //    this.IdEmp = _idEmp;
        //    this.Avatar = _avatar;
        //    this.Birthday = _birthday;
        //    this.Gender = _gender;
        //    this.Addredd = _addredd;
        //    this.Idcard = _idcard;
        //    this.Phone = _phone;
        //    this.Salary = _salary;
        //    this.Idarea = _idarea;
        //    this.State = _state;
        //    this.Email = email;

        //}
        public EmployeeDTO(string _idEmp,string _fullName,Image _avatar,
        DateTime _birthday,
         int _gender,
        string _addredd,
         string _idcard,
         string _phone,
         int _salary,
         int _idarea,
         string _state,
         string email)
        {
            this.FullName = _fullName;
            this.IdEmp = _idEmp;
            this.Avatar = _avatar;
            this.Birthday = _birthday;
            this.Gender = _gender;
            this.Addredd = _addredd;
            this.Idcard = _idcard;
            this.Phone = _phone;
            this.Salary = _salary;
            this.Idarea = _idarea;
            this.State = _state;
            this.Email = email;
        }

    }
}
