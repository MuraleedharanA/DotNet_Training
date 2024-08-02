using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class A
    {
        public A() {
            Console.WriteLine("A");
        }
    }
    //single level
    public class B: A{
        public B()
        {
            Console.WriteLine("B");
        }
    }
    //multiple
    public class C: A
    {
        public C()
        {
            Console.WriteLine("C");
        }
    }
    //multilevel
    public class D: B { 
        public D()
        {
            Console.WriteLine("D");
        }
    }
    internal class Inheritance
    {
        public static void Main3()
        {
            Console.WriteLine(".....Multilevel.......");
            D d=new D();
            Console.WriteLine(".....Multiple.......");
            C c=new C();
            Console.WriteLine("......Single......");
            B b=new B();
        }
    }
}
