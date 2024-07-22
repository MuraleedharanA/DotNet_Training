namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double electricitybill, electricityunit, surchargebill;
            Console.WriteLine("Enter consumed electricity unit : ");
            electricityunit = Convert.ToDouble(Console.ReadLine());
            if (electricityunit < 50)
            {
                electricitybill = electricityunit * 0.5;

            }
            else if(electricityunit < 150)
            {
                electricitybill = (50 * 0.5) + ((electricityunit - 50) * 0.75);
            }
            else if(electricityunit < 250)
            {
                electricitybill = (50 * 0.5) +(100*0.75)+ ((electricityunit - 150) * 1.20);
            }
            else
            {
                electricitybill = (50 * 0.5) + (100 * 0.75) + (100*1.20) + ((electricityunit - 250) * 1.50);
            }
            Console.WriteLine($"Electricity bill : {electricitybill}");

            surchargebill = electricitybill+(electricitybill * 0.20);
            Console.WriteLine($"Electricity bill with Surcharge: {surchargebill}");


        }
    }
}