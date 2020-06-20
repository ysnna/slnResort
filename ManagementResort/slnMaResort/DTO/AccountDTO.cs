using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMaResort.DTO
{
    public class AccountDTO
    {
        private String _userName;
        private string _pass;
        private string _idGroup;
        private string _idEmp;

        //permission
        private int _idPer;
        private string _namePer;
        private string _descripPer;

        //group
        private string _nameGroup;
        private string _descripGroup;

        public string UserName { get => _userName; set => _userName = value; }
        
        public string IdGroup { get => _idGroup; set => _idGroup = value; }
        public string IdEmp { get => _idEmp; set => _idEmp = value; }
        public int IdPer { get => _idPer; set => _idPer = value; }
        public string NamePer { get => _namePer; set => _namePer = value; }
        public string DescripPer { get => _descripPer; set => _descripPer = value; }
        public string NameGroup { get => _nameGroup; set => _nameGroup = value; }
        public string DescripGroup { get => _descripGroup; set => _descripGroup = value; }
        public string Pass { get => _pass; set => _pass = value; }
    }
}
