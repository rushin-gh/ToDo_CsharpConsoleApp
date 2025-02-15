using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Data
{
    internal class MSG_Dict
    {
        public static Dictionary<string, string> MsgDict = new Dictionary<string, string>
        {
            { "MSG0000", "Welcome to ToDo app!" },
            { "MSG0001", "Username cannot be empty!" },
            { "MSG0002", "Userpassword cannot be empty!" },
            { "MSG0003", "Invalid inputs!" },
            { "MSG0004", "Successfully Logged In!" },

        };
    }
}
