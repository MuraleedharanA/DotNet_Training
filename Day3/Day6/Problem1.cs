using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day6.Program;

namespace Day6
{
    internal class Problem1
    {
        public class Person
        {
            public string name;
            public Person(string name)
            {
                this.name = name;
            }
            ~Person() {
                this.name = "";
            }
            public override string ToString()
            {
                return this.name;
            }
        }
        static void Main2(string[] args)
        {
            
            Person[] personArray = new Person[5];
            for( int i = 1; i <=3; i++ )
            {
                Console.WriteLine("Enter name "+i+" : ");
                string name= Console.ReadLine();
                personArray[i] = new Person(name);

            }
            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("Hello My name is " + personArray[i].ToString());

            }

            //Console.WriteLine("Enter name : ");
        }
    }
}
