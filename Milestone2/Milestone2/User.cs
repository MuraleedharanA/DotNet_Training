using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    internal class User
    {
        String username {  get; set; }
        String Password { get; set; }
        String email { get; set; }

        public User(string username, string password, string email)
        {
            this.username = username;
            Password = password;
            this.email = email;
        }
    }
}
