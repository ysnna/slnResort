using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    class CustomerDTO
    {
        private string _idus;
        private string _name;
        private DateTime _birthday;
        private int _gender;
        private string _idcard;
        private string _phone;
        private string _idroom;

        public string Idus { get => _idus; set => _idus = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public int Gender { get => _gender; set => _gender = value; }
        public string Idcard { get => _idcard; set => _idcard = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Idroom { get => _idroom; set => _idroom = value; }
    }
}
