using BaseCleanArchProject.Domain.models;
using BaseCleanArchProject.Infra.repos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCleanArchProject.Presentation.controllers.user_controller
{
    internal class User_controller
    {
        public User_controller()
        {
        }

        public User Signup (string id, string name, string email, string password)
        {
            UserRepo user = new UserRepo(id, name, email, password);
            User addedUser = user.Add();
            return addedUser;
        }
    }
}
