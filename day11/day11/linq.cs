using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11
{   class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }
        public string Gender {  get; set; }
    }
    internal class linq
    {
        public static void Main()
        {
            //String[] arr = { "csharp", "c++", "java" };
            //var r = from lang in arr where lang.Contains("c") select lang;
            //foreach ( String s in r )
            //{
            //    Console.WriteLine( s );
            //}

            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Athi", Salary = 90000, Gender="Female" });
            list.Add(new Employee() { Id = 1, Name = "Syam", Salary = 8000, Gender = "male" });
            list.Add(new Employee() { Id = 1, Name = "Akshay", Salary = 70000, Gender = "male" });
            list.Add(new Employee() { Id = 1, Name = "Yeshwika", Salary = 190000, Gender = "Female" });
            list.Add(new Employee() { Id = 1, Name = "Gayathri", Salary = 9022000, Gender = "Female" });
            list.Add(new Employee() { Id = 1, Name = "Reshma", Salary = 906777000, Gender = "Female" });

            var r = from emp in list where emp.Salary<1000 select emp;
            //Group By
            //var grp = list.GroupBy(x => x.Gender).ToList();
            //foreach(var item in grp)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine("++++++++++++++++++++++++++++");
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }
                
            //}
            ////Lookup
            //var grp = list.ToLookup(x => x.Gender).ToList();
            //foreach (var item in grp)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine("++++++++++++++++++++++++++++");
            //    foreach (var emp in item)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }

            //}
            ////Avg
            //var test = list.Average(x => x.Salary);
            //Console.WriteLine(test.ToString());

            ////sum
            //var test = list.Sum(x => x.Salary);
            //Console.WriteLine(test.ToString());

            

        }
    }
}
