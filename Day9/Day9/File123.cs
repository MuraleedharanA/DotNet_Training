using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class File123
    {
        public static void Main354()
        {
            //FileStream fileStream = new FileStream(@"D:\Newfile.txt", FileMode.Append);
            //Byte[] bytes = Encoding.Default.GetBytes("Hi I am Athira");
            //fileStream.Write(bytes,0,bytes.Length);
            //fileStream.Close();
            //

            FileStream filestream = new FileStream(@"D:\Newfile.txt", FileMode.Open, FileAccess.Read);
            string data;
            using(StreamReader sr = new StreamReader(filestream))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            filestream.Close();
        }   
    }
}
