using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmlthisgamesucks060524
{
    internal class ElectricCar : Vehicle
    {
        public double BatteryLevel { get; set; }

        public void Charge(double amount)
        {
            BatteryLevel += amount;
            Console.WriteLine($"Charged. Current battery level: {BatteryLevel} kWh");
        }
    }
}
