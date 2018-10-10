using _04_Employee_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Employee_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();

            Console.WriteLine("Enter Employee ID:");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEnter Employee Name:");
            var name = Console.ReadLine();

            Console.WriteLine($"\nEnter Employee Age:");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEnter Employee Salary:");
            var salary = double.Parse(Console.ReadLine());

            Employee newEmployee = new Employee()
            {
                EmployeeID = id,
                Age = age,
                Salary = salary,
                Name = name,
            };

            employeeRepo.AddEmployeeToList(newEmployee);

            var newList = employeeRepo.GetList();

            foreach(Employee employee in newList)
            {
                Console.WriteLine(employee.EmployeeID + " " + employee.Name);
            }

            Console.ReadLine();
        }
    }
}
