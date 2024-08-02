namespace Day6
{
    internal class Program
    {
        public class Vehicle
        {
            public string name;
            public string color;
            public Vehicle(Vehicle V)
            {
                this.name = V.name;
                this.color = V.color;
            }
            public Vehicle(string name, string color)
            {
                this.name = name;
                this.color = color;
            }
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehicle v1 = new Vehicle("i20", "Grey");
            Vehicle v2 = new Vehicle(v1);
        }
    }
}