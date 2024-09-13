using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class StreamReaderWriter
    {
        public static void Maingbx()
        {
            //StreamWriter streamWriter= new StreamWriter(@"D:\Newfile.txt",true);
            //Console.WriteLine("Enter data");
            //string data = Console.ReadLine();
            //streamWriter.Write(data);
            //streamWriter.Flush();
            //streamWriter.Close();
            StreamReader streamReader = new StreamReader(@"D:\Newfile.txt");
            streamReader.BaseStream.Seek(0,SeekOrigin.Begin);
            string data2 = streamReader.ReadLine();
            while (data2 != null)
            {
                Console.WriteLine(data2);
                data2 = streamReader.ReadLine();

            }
            streamReader.Close();
        }
    }
}
