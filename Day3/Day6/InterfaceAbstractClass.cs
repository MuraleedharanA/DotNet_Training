using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public interface IVehicleo
    {
        
        public void Drive();
        public bool Refuel(int refuel);
    }
    class Car : IVehicleo
    {
        int gas;
       
        public void Drive()
        {
            if(this.gas > 0) {
                Console.WriteLine("Driving");
            }
            
        }

        public bool Refuel(int refuel)
        {
            this.gas = gas + refuel;
            return true;
        }
    }
    internal class InterfaceAbstractClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            int addGas = int.Parse(Console.ReadLine());
            car.Refuel(addGas);
            car.Drive();
        }
    }
}
