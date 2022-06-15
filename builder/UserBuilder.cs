using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// own imports
using ApplicationCsharp.entity;

namespace ApplicationCsharp.builder
{
    internal class UserBuilder: JsonBuilder<List<User>>
    {
        public static List<User> CreateListOfUsers()
        {
            return Build("user");
        }
    }
}
