using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class UsersClass
    {
        private static Lazy<UsersClass> _instance; //= new Lazy<UsersClass>(() => new UsersClass());
        private UsersClass(string username, string email) {
            this.username = username;
            this.email = email;
        }
        public static UsersClass Instance(string username, string email)
        {
            if(_instance == null)
            {
                _instance = new Lazy<UsersClass>(new UsersClass(username, email));
            }
            return _instance.Value;
        }
        public string username { get; set; }
        public string email { get; set; }
    }
}
