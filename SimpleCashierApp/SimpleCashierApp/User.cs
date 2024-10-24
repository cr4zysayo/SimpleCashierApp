using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCashierApp
{
    public abstract class User
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public User(string name, string uName, string password)
        {
            this.full_name = name;
            this.user_name = uName;
            this.user_password = password;
        }
        public abstract bool validateLogin(string uNmae, string password);
        public string getFullName()
        {
            return full_name = "James Vladimir Z. Gacis";
        }
    }
}
