using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class outKeyword
    {
        public static void swapout( int a,  int b, out int output)
        {
            output = a + b;
        }
        public static void swapref(ref int a, ref int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main2(string[] args)
        {
            
            int a = 10, b = 15,output=0;
            swapout(a, b,out output);
            swapref(ref a, ref b);
            Console.WriteLine(output);

        }
    }
}
