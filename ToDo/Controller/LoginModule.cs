using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Controller
{
    internal class LoginModule
    {
        public LoginModule()
        {
            OutputModel.PrintLine(ErrorMsgDict.MsgDict["MSG0000"]);
            OutputModel.EmptyLine(1);
        }

        public bool UserLogin()
        {
            string userName, userPassword;
            OutputModel.Print("Username : "); userName = Console.ReadLine();
            OutputModel.Print("Password : "); userPassword = Console.ReadLine();

            OutputModel.EmptyLine(1);

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userPassword))
            {
                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine(ErrorMsgDict.MsgDict["MSG0001"]);
                }
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userPassword))
                {
                    Console.WriteLine(ErrorMsgDict.MsgDict["MSG0002"]);
                }
                Console.WriteLine(ErrorMsgDict.MsgDict["MSG0003"]);
                return false;
            }

            Console.WriteLine(ErrorMsgDict.MsgDict["MSG0004"]);
            return true;
        }
    }
}
