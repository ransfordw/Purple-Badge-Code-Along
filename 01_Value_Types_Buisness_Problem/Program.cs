using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Buisness_Problem
{
    class Program
    {
        public enum VehicleType
        {
            Car = 1, Boat, Motorcycle, Plane
        }
        static void Main(string[] args)
        {
            string customerName;
            int customerAge;
            VehicleType customerVehicle;
            decimal premium = 0m;

            Console.WriteLine("What is your name?");
            customerName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            customerAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"What type of vehicle would you like to insure?\n\n\t" +
                $"1. Car\n\t" +
                $"2. Boat\n\t" +
                $"3. Motorcycle\n\t" +
                $"4. Plane");
            var newVehicle =Int32.Parse(Console.ReadLine());
            customerVehicle = (VehicleType)newVehicle;

            switch(customerVehicle)
            {
                case VehicleType.Car:
                    if (customerAge >= 18 && customerAge < 27) premium = 150.00m;
                    else if (customerAge >= 27 && customerAge < 65) premium = 50.00m;
                    else if (customerAge >=65) premium = 100.00m;
                    break;

                case VehicleType.Boat:
                    if (customerAge >= 18 && customerAge < 27) premium = 200.00m;
                    else if(customerAge >= 27 && customerAge < 65) premium = 100.00m;
                    else if (customerAge >= 65) premium = 150.00m;
                    break;

                case VehicleType.Motorcycle:
                    if (customerAge >= 18 && customerAge < 27) premium = 200.00m;
                    else if(customerAge >= 27 && customerAge < 65) premium = 100.00m;
                    else if (customerAge >= 65) premium = 250.00m;
                    break;

                case VehicleType.Plane:
                    if (customerAge >= 18 && customerAge < 27) premium = 1000.00m;
                    else if(customerAge >= 27 && customerAge < 65) premium = 500.00m;
                    else if (customerAge >= 65) premium = 1000.00m;
                    break;
            }

            Console.WriteLine($"Your insurance premium for your {customerVehicle} is ${premium}");
            Console.ReadLine();

        }
    }
}
