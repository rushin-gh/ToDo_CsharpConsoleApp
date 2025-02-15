using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    internal class UserModel
    {
        // int userId { get; set; }

        public required string UserName { get; set; }

        public required string UserPassword { get; set; }

        public UserModel(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }
    }
}
