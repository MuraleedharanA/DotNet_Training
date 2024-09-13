using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{   abstract class Animal
    {
        string name {  get; set; }
        abstract public void eat();
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
    internal class AbstractClassDemo
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();

        }
    }
}
