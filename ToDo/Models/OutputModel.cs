using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    internal class OutputModel
    {
        public static void Print(object text)
        {
            Console.Write(text);
        }

        public static void PrintLine(object text)
        {
            Console.WriteLine(text);
        }

        public static void EmptyLine(int cnt)
        {
            Console.Write(new String('\n', cnt));
        }
    }
}
