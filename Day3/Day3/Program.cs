using System.Data;

namespace Day3
{
    internal class Program
    {
      
        public static void swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($" val of a = {a} and val of b = {b} after swap");
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 10, b = 15;
            Console.WriteLine($" init val of a = {a} and init value of b = {b}");
            swap(ref a, ref b);
            Console.WriteLine($"val of a = {a} and val of b = {b} in main after swap");
        }
        
    }
}