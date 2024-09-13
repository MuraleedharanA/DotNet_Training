namespace Milestone2_Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string email { get; set; }

        public void getDEtails()
        {

        }
    }
    class Customer : Person
    {
        public string CustomerID { get; set; }
        public double customerDiscountPercentage { get; set; }
    }
    class Admin : Person
    {
        public string AdminID { get; set; }

        public void verifyOrder()
        {
            Console.WriteLine("ORder verified by Admin");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Customer customer = new Customer();

            admin.Name = "Athira Muraleedharan";
            admin.email = "adminAthira@xyz.com";
            admin.AdminID = "252210";

            customer.Name = "Max";
            customer.customerDiscountPercentage = 10;
            customer.email = "MAx@xyz.com";
            customer.CustomerID = "cus10";






        }
    }
}