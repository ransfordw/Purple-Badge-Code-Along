using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType
        {
            Male, Female, Unknown
        }

        static void Main(string[] args)
        {
            //-- Integers
            int i = 100;

            //-- Declaration
            int myAge;

            //-- Initiailization
            myAge = 42;

            //-- Other Integer Types
            byte by = 255; //-- int range of 0-255
            float PI = 3.141592653145981234f; //-- 32-bit
            double d = 780.01; //-- 64-bit
            decimal p = 7.8m; //-- 128-bit use for money or precise calculations
            int? noValue = null;
            long youtubeMinutesWatched = 1234567891234567890; //-- range -9,223,372,036,854,775,808 to 9,223,372,036,854,775,808
            short sh = 32767; //-- 32767 is max value for a short
            int iToo = -2147483648; //-- minimum value at left, max is the positive value 

            //-- Booleans
            bool isEarly = true;

            //-- Boolean Logic/Conditionals
            if (isEarly)
                Console.WriteLine("need more coffee");

            //-- Declare Enum
            GenderType myGender = GenderType.Male;

            switch (myGender)
            {
                case GenderType.Male:
                    Console.WriteLine("You are a boy");
                    break;
                case GenderType.Female:
                    Console.WriteLine("You are a girl");
                    break;
                case GenderType.Unknown:
                    Console.WriteLine("You are a ????");
                    break;
            }


            Console.WriteLine($"{i} {myAge} {p} {PI} {noValue} {youtubeMinutesWatched} {d} {by} {sh} {iToo}");
            Console.ReadLine();
        }
    }
}
