using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Person
    {
        protected int age;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }

    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Iam Studying");
        }
        public void showAge()
        {
            Console.WriteLine("My Age is " + this.age + " years");
        }
    }
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Iam Explaining");
        }
    }

    internal class StudentProfessorTest
    {
        public static void Main5()
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge(12);
            student.Greet();
            student.showAge();
            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.SetAge(32);
            teacher.Explain();


        }
    }
}
