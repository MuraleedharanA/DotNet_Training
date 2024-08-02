using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Palandrome
    {
        static void Main5(string[] args)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder reverseString = new StringBuilder();
            str.Append(Console.ReadLine());           
            //reverse string
            for(int i = str.Length-1; i >= 0; i--)
            {
                reverseString.Append(str[i]);

            }
            Console.WriteLine(reverseString.ToString());
            Console.WriteLine(str.ToString());
            if (reverseString.Equals(str))
            {
                Console.WriteLine("PALINDROME");
            }
            else
            {
                Console.WriteLine("Not PALINDROME");
            }
        }
    }
}
