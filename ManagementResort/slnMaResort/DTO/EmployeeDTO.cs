using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
