using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class stringBuilderDemo
    {
        static void Main2(string[] args)
        {
            StringBuilder str = new StringBuilder();
            String newStr = "Athira";
            str.Append(newStr);
            Console.WriteLine(str);
            for(int i = 0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }
            str.Clear();
            str.Append("Muraleedharan");
            Console.WriteLine(str);


        }
    }
}
