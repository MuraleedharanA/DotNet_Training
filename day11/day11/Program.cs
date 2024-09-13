using System.Text.RegularExpressions;

namespace day11
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string pattern = "[0-9]{4}";
            string pattern2 = "a*b";
            string pattern3 = "a+b";
            Regex rex = new Regex(pattern3);
            string x = "ab";
            if(rex.IsMatch(x))
            {
                Console.WriteLine("match");
            }
            else
            {
                Console.Write("not match");
            }
           // Console.WriteLine("Hello, World!");
        }
    }
}