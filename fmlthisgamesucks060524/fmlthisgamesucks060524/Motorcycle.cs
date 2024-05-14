using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmlthisgamesucks060524
{
    internal class Motorcycle : Vehicle
    {
        public bool HelmetOn { get; set; }

        public void ToggleHelmet()
        {
            HelmetOn = !HelmetOn;
            Console.WriteLine($"Helmet {(HelmetOn ? "on" : "off")}");
        }
        public double FuelLevel { get; set; }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            Console.WriteLine($"Refueled. Current fuel level: {FuelLevel} liters");
        }
    }
}
