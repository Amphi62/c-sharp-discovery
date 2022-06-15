using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCsharp.entity
{
    internal class User
    {
        public string Username { get; set; }

        public String Email { get; set; }

        public User(string Username, string Email)
        {
            this.Username = Username;
            this.Email = Email;
        }

        public override string ToString()
        {
            return $"{Username} ({Email})";
        }
    }
}
