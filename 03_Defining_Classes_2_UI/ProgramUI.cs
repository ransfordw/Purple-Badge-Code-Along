using _03_Defining_Classes_2;
using System;

namespace _03_Defining_Classes_2_UI
{
    class ProgramUI
    {
        private WeatherRepository _weatherRepo = new WeatherRepository();

        public void Run()
        {
            Console.WriteLine("What is the current temperature?");
            var temperature = float.Parse(Console.ReadLine());

            Console.WriteLine("What is the wind direction?");
            var direction = int.Parse(Console.ReadLine());
            var windDirection = (WindDirection)direction;

            Console.WriteLine("What is the wind speed?");
            var speed = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the ID?");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Is there precipitation? y or n");
            var precipResponse = Console.ReadLine();
            bool precipitaion;
            if (precipResponse == "y")
                precipitaion = true;
            if (precipResponse == "n")
                precipitaion = false;
         
        }
    }
}