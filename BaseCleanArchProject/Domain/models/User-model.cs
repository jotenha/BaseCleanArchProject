using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCleanArchProject.Domain.models
{
    //user stub exemple
    internal class User
    {
        string id;
        string name;
        string email;
        string password;

        public User(string id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
    }
}
