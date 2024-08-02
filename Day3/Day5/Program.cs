namespace Day5
{
    internal class Program
    {
        public class Employee
        {
            //fields
            public string employeeNumber;
            public string employeeName;
            public double employeeSalary;
            public string employeGender;

            public Employee(string employeeNumber, string employeeName, double employeeSalary, string employeGender)
            {
                this.employeeNumber = employeeNumber;
                this.employeeName = employeeName;
                this.employeeSalary = employeeSalary;
                this.employeGender = employeGender;
            }



            public void printDetails()
            {
                Console.WriteLine(" Employee Number :" + this.employeeNumber);

                Console.WriteLine(" Employee Name :" + this.employeeName);

                Console.WriteLine(" Employee Salary :" + this.employeeSalary);

                Console.WriteLine(" Employee Gender :" + this.employeGender);
            }


        }
        static void Main1(string[] args)
        {

            Employee employee = new Employee("1234", "Athira", 1000, "F");
            employee.printDetails();
        }
    }
}

