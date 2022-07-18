using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternChallenge

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires would you like on your vehicle?");
            var numOfTires = int.Parse(Console.ReadLine());
            var newVehicle = VehicleFactory.GetVehicle(numOfTires);
            newVehicle.Drive();
            
        }
    }
}
