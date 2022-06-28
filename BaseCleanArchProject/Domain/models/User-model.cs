using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCleanArchProject.Domain.models
{
    //user stub exemple
    internal class UserModel
    {
        string id;
        string name;
        string email;
        string password;

        public UserModel(string id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
    }
}
