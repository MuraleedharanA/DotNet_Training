using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Employee
    {
        //fields
        public string employeeNumber;
        public string employeeName;
        public double employeeSalary;
        public string employeGender;

        //methods
        public  void getDetails(ref Employee employee)
        {
            Console.WriteLine("Enter Employee Number :");
            employee.employeeNumber = Console.ReadLine();

            Console.WriteLine("Enter Employee Name :");
            employee.employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary :");
            employee.employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Gender :");
            employee.employeGender = Console.ReadLine();
        }

        public  void printDetails(Employee employee)
        {
            Console.WriteLine(" Employee Number :"+employee.employeeNumber );

            Console.WriteLine(" Employee Name :"+employee.employeeName);

            Console.WriteLine(" Employee Salary :"+employee.employeeSalary);

            Console.WriteLine(" Employee Gender :"+employee.employeGender);
        }


    }
    internal class Employees
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.getDetails(ref employee);
            employee.printDetails(employee);

        }
    }
}