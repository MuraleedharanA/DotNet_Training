using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day9
{
    internal class FileClassDEmo
    {
        public static void Main()
        {
            string f1 = @"D:\NewFile.txt";
            string f2 = @"D:\test\NewFile.txt";
            string f3 = @"D:\NewFile123.txt";
            if (File.Exists(f1))
            {
                File.Copy(f1, f2);
                File.Delete(f1);
                File.Create(f3);
            }
        }
    }
}
