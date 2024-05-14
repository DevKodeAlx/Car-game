using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmlthisgamesucks060524
{
    internal class GasCar : Vehicle
    {
        public double FuelLevel { get; set; }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            Console.WriteLine($"Refueled. Current fuel level: {FuelLevel} liters");
        }
    }
}
