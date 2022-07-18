using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternChallenge
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numOfTires)
        {
            IVehicle answer = numOfTires == 2 ? (IVehicle) new Motorcycle() : (IVehicle) new Car();
            return answer;

        }
    }
}
