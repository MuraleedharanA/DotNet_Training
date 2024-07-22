namespace Question1_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basicsalary, grossSalary=0;

            // Read basic salary
            Console.WriteLine("Enter basic salary of employee : ");
            basicsalary = double.Parse(Console.ReadLine());

            if(basicsalary<=10000)
            {
                grossSalary = basicsalary + (basicsalary * 0.2) + (basicsalary * 0.8);
            }
            else if (basicsalary <= 20000)
            {
                grossSalary = basicsalary + (basicsalary * 0.25) + (basicsalary * 0.9);
            }
            else if (basicsalary > 20000)
            {
                grossSalary = basicsalary + (basicsalary * 0.3) + (basicsalary * 0.95);
            }

            Console.WriteLine($"Gross Salary of employee : {grossSalary}");
        }
    }
}