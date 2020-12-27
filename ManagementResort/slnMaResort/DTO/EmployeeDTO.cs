using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.DTO
{
    class EmployeeDTO : abObser
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
        private string _email;
        public string Email { get => _email; set => _email = value; }
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

        public override void ObserverInfo(string info)
        {

            sentmail(FullName, Email, info);
            MessageBox.Show("Đã gửi mail đến " + FullName + " về sản phẩm " + info);
        }

        void sentmail(string name, string email, string info)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("17110108@hcmute.edu.vn", "01225032233");
                MailMessage msg = new MailMessage();
                msg.To.Add(email);
                msg.From = new MailAddress("17110108@gmail.com");
                msg.Subject = "Cập nhật sản phẩm từ công ty HCMUTE";
                msg.Body = "Thông báo đến : " + name + "  Thông tin sản phẩm :   " + info;
                client.Send(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public EmployeeDTO(string _idEmp, int _idarea, string _email)
        {
            this.IdEmp = _idEmp;
            this.Idarea = _idarea;
            this.Email = _email;
        }
    }
}
