namespace Day9
{   interface IWholeseller
    {
        void Discount();
    }

    interface IRetailer
    {
        void Discount();
    }
    class Buyer : IRetailer, IWholeseller
    {
        void IWholeseller.Discount()
        {
           
            Console.WriteLine("Iwholeseller");
        }

        void IRetailer.Discount()
        {
            Console.WriteLine("Iretailer");
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            IRetailer retailer = new Buyer();
            IWholeseller wholeSeller = new Buyer();
            retailer.Discount();
            wholeSeller.Discount();
        }
    }
}