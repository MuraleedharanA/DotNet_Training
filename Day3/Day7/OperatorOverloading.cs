using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Sample
    {
        int num1, num2; 
        public Sample(int a, int b)
        {
            this.num1 = a;
            this.num2 = b;
        }
        public void print()
        {
            Console.WriteLine(this.num1 + "\n" + this.num2);
        }
        public static Sample operator +(Sample s1 , Sample s2)
        {
            Sample s3=new Sample(0,0);
            s3.num1 = s1.num1+s2.num1;
            s3.num2 = s1.num2+s2.num2;
            return s3;  
        }
        public static Sample operator *(Sample s1, Sample s2)
        {
            Sample s3 = new Sample(0, 0);
            s3.num1 = s1.num1 * s2.num1;
            s3.num2 = s1.num2 * s2.num2;
            return s3;
        }


    }
    internal class OperatorOverloading
    {
        public static void Main()
        {
            Sample s1= new Sample(1,2);
            Sample s2= new Sample(2,3);
            Sample s3 = s1 + s2;
            Sample s4 = s1 * s2;
            s4.print() ;
        }
    }
}
