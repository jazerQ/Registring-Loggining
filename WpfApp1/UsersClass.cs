using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class UsersClass
    {
        public string username { get; set; }
        public string email { get; set; }
        public UsersClass(string username, string email)
        {
            this.username = username;
            this.email = email;
        }
    }
    static class CabinetUser
    {
        static public UsersClass user = null!;

    }
}
