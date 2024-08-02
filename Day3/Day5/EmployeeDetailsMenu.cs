using Day5;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class EmployeeDetails
    {
            //fields
            public string employeeNumber;
            public string employeeName;
            public double employeeSalary;
            public string employeGender;

            /*public EmployeeDetails(string employeeNumber, string employeeName, double employeeSalary, string employeGender)
            {
                this.employeeNumber = employeeNumber;
                this.employeeName = employeeName;
                this.employeeSalary = employeeSalary;
                this.employeGender = employeGender;
            }
            */


            public void printDetails()
            {
                Console.WriteLine(" Employee Number :" + this.employeeNumber);

                Console.WriteLine(" Employee Name :" + this.employeeName);

                Console.WriteLine(" Employee Salary :" + this.employeeSalary);

                Console.WriteLine(" Employee Gender :" + this.employeGender);
            }
            public void getEmployeeDEtails()
            {
                Console.WriteLine("Enter Employee Number :");
                this.employeeNumber = Console.ReadLine();

                Console.WriteLine("Enter Employee Name :");
                this.employeeName = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary :");
                this.employeeSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Gender :");
                this.employeGender = Console.ReadLine();
            }
            

        }

    
    internal class EmployeeDetailsMenu
    {
        static void Main(string[] args)
        {

            int option = 0,counter=0;
            EmployeeDetails[] employeeDetailsArray = new EmployeeDetails[10];
            do
            {
                Console.WriteLine("Employee Menu\n1.\tAdd Employee\n2.\tUpdate Employee\n3.\tDelete Employee\n4.\tList\n5.\tExit");
                bool isCorrectOption = int.TryParse(Console.ReadLine(),out option);
                if (isCorrectOption)
                {
                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("Adding new Employee");
                            EmployeeDetails employeeDetails = new EmployeeDetails();
                            employeeDetails.getEmployeeDEtails();
                            employeeDetailsArray[counter]=employeeDetails;
                            counter++;
                            break;
                        case 2:
                            Console.WriteLine("Emlpoyee update...");
                            Console.WriteLine("Enter Employee Number :");
                            string empid = Console.ReadLine();
                            for(int i = 0; i < counter; i++)
                            {
                                if (employeeDetailsArray[i].employeeNumber == empid)
                                {
                                    Console.WriteLine("Enter employee details : ");
                                    employeeDetailsArray[i].getEmployeeDEtails();
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Emplpoyee delete..");
                            Console.WriteLine("Enter Employee Number :");
                            string empidDelete = Console.ReadLine();
                            for (int i = 0; i < counter; i++)
                            {
                                if (employeeDetailsArray[i].employeeNumber == empidDelete)
                                {

                                    employeeDetailsArray[i] = null;
                                    employeeDetailsArray[i] = employeeDetailsArray[i + 1];
                                    counter--;
                                }
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exiting Menu");
                            break;
                        case 4:
                            Console.WriteLine("Listing Employees");
                            for (int i = 0;i< counter; i++)
                            {
                                employeeDetailsArray[i].printDetails();
                                Console.WriteLine("\n\n");

                            }
                            break;
                        default:
                            break;

                    }
                }

            }while(option!=5);

        }
    }
}
