using BaseCleanArchProject.Domain.models;
using BaseCleanArchProject.Domain.usecases.User_usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCleanArchProject.Infra.repos
{
    internal class UserRepo : UserModel, Iadd_user, Iremove_user
    {
        public UserRepo(string id, string name, string email, string password) : base(id, name, email, password)
        {
        }

        public User Add()
        {
            //Database add
            throw new NotImplementedException();
        }

        public bool Remove()
        {
            //Database remove
            throw new NotImplementedException();
        }
    }
}
