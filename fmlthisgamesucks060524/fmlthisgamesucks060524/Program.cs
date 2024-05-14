using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmlthisgamesucks060524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a vehicle type:");
            Console.WriteLine("1. GasCar");
            Console.WriteLine("2. ElectricCar");
            Console.WriteLine("3. Motorcycle");
            Console.Write("Enter your choice (1/2/3): ");
            int choice = int.Parse(Console.ReadLine());

            Vehicle selectedVehicle;

            switch (choice)
            {
                case 1:
                    selectedVehicle = new GasCar { Make = "BMW", Model = "M5", Year = 2022, FuelLevel = 15 };
                    Console.WriteLine();
                    Console.WriteLine("Chosen vehicle: Gasoline car, BMW M5!");
                    
                    break;
                case 2:
                    selectedVehicle = new ElectricCar { Make = "Audi", Model = "E-Tron", Year = 2023, BatteryLevel = 15 };
                    Console.WriteLine();
                    Console.WriteLine("Chosen vehicle: Electric car, Audi, E-Tron!");

                    break;
                case 3:
                    selectedVehicle = new Motorcycle { Make = "Husqvarna", Model = "Svart Pilen", Year = 2021, FuelLevel = 10 };
                    Console.WriteLine();
                    Console.WriteLine("Chosen vehicle: Motorcycle, Husqvarna, Svartpilen!");

                    Console.WriteLine();
                    Console.WriteLine("Helmet on, lets ride.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    return;
            }

            selectedVehicle.StartEngine();

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Accelerate");
                Console.WriteLine("2. Brake");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1/2/3): ");
                int actionChoice = int.Parse(Console.ReadLine());

                switch (actionChoice)
                {
                    case 1:
                        selectedVehicle.Accelerate(2.5); // Adjust fuel consumption (2,5 liters per acceleration)
                        if (selectedVehicle is GasCar)
                        {
                            Console.WriteLine();
                            Console.WriteLine("VROOOM!!");
                        }
                        else if (selectedVehicle is ElectricCar)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Swoosh!");
                        }
                        else if (selectedVehicle is Motorcycle)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bratattata!!");
                        }
                        break;
                    case 2:
                        selectedVehicle.Brake();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Exiting. Have a great day!");
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                if (selectedVehicle is GasCar gasCar)
                {
                    if (gasCar.FuelLevel <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Out of fuel! Game over.");
                        return;
                    }
                }
                else if (selectedVehicle is ElectricCar electricCar)
                {
                    if (electricCar.BatteryLevel <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Out of battery charge! Game over.");
                        return;
                    }

                }
                else if (selectedVehicle is Motorcycle motorcycle)
                {
                    if (motorcycle.FuelLevel <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Out of fuel! Game over.");
                        return;
                    }
                }
            }
        }
    }
}

    
    

