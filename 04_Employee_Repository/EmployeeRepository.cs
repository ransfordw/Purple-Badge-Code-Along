using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Employee_Repository
{
    public class EmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();

        public void AddEmployeeToList(Employee model)
        {
            _employees.Add(model);
        }

        public List<Employee> GetList()
        {
            return _employees;
        }

        public void RemoveEmployeeByName(string name)
        {
            foreach(Employee employee in _employees)
            {
                if (employee.Name == name)
                {
                    _employees.Remove(employee);
                    break;
                }
            }
        }
    }
}
