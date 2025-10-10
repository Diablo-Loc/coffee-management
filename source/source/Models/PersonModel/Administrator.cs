using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models.PersonModel
{
    internal class Administrator : Person
    {
        private string _Username;
        private string _Password;
        public string Username { get { return _Username; } set { _Username = value; } }
        public string Password { get { return _Password; } set { _Password = value; } }    
        public Administrator(): base(){ }
        public Administrator (string fullName, string email, string phone, string username, string password) : base(fullName, email, phone)
        {
            this._Username = username;
            this._Password = password;
        }
    }
}
