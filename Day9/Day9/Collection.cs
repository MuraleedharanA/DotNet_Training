using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{   class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void getData()
        {
            Console.WriteLine("Enter Employee ID");
            this.Id =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter Employee NAme");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            this.Salary = double.Parse(Console.ReadLine());
        }

    }
    internal class Collection
    {
        public static void Main6()
        {
            List<Employee> empList = new List<Employee>();
            for(int i = 0; i < 2; i++)
            {
                Employee emp = new Employee();
                emp.getData();
                empList.Add(emp);
            }
            foreach(Employee emp in empList)
            {
                Console.WriteLine("EmpID : "+emp.Id); Console.WriteLine("Emp Name : "+emp.Name); Console.WriteLine("Emp Salary"+emp.Salary);
            }

            Dictionary<int,String> empdictiionary = new Dictionary<int,String>();
            
                empdictiionary.Add(1,"temp");
                empdictiionary.Add(2, "temp");
                empdictiionary.Add(3, "temp");

           
            foreach(var emp in empdictiionary)
            {
                Console.WriteLine(emp.Key+" : " + emp.Value);
            }
            Console.WriteLine("===================Hash set==============");
            HashSet<int> ints = new HashSet<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(2);

            foreach(int i in ints)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine("=================Queue================");
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(2);

            while(myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue);
            }

            Console.WriteLine("=================Stack================");
            Stack<int> myStack= new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(2);

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop);
                
            }


        }
        
    }
}
