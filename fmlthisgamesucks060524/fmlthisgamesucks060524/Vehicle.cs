using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmlthisgamesucks060524
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Speed { get; set; }

        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine("Engine started!");
        }

        public void Accelerate(double fuelConsumption)
        {
            Speed += 10;
            Console.WriteLine();
            Console.WriteLine($"Accelerating. Current speed: {Speed} km/h");

            if (this is GasCar gasCar)
            {
                gasCar.FuelLevel -= fuelConsumption;
                Console.WriteLine($"Fuel consumed: {fuelConsumption} liters. Current fuel level: {gasCar.FuelLevel} liters");
            }
            else if (this is ElectricCar electricCar)
            {
                electricCar.BatteryLevel -= fuelConsumption;
                Console.WriteLine($"Charge consumed: {fuelConsumption} kWh. Current battery level: {electricCar.BatteryLevel} kWh");
            }
            else if (this is Motorcycle motorcycle)
            {
                motorcycle.FuelLevel -= fuelConsumption;
                Console.WriteLine($"Fuel consumed: {fuelConsumption} liters. Current fuel level: {motorcycle.FuelLevel} liters");
            }
        }

        public void Brake()
        {
            Speed -= 5;
            if (Speed <= 0)
            {
                Speed = 0; // Ensure speed doesn't go negative
                Console.WriteLine();
                Console.WriteLine("Vehicle has stopped.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Braking. Current speed: {Speed} km/h");
            }
            
        }
    }
}

