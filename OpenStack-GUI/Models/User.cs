using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStack_GUI.Models
{
    class User
    {
        public string nome { get; set; }
        public string id { get; set; }

        public string password { get; set; }
        public string email { get; set; }
        public string userid { get; set; }
        public string description { get; set; }

        public User()
        {
            this.nome = null;
            this.password = null;
            this.email = null;
            this.userid = null;
            this.description = null;
        }
    }
}
