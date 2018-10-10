using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Repos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Hello(name);
            var age = GetAge();

            Console.WriteLine($"You are {age} years old");

            Console.ReadLine();
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static int GetAge()
        {
            Console.WriteLine("Enter your age:");
            var age = Int32.Parse(Console.ReadLine());
            return age;
        }
    }
}
