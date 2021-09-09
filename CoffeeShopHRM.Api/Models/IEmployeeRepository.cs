using CoffeeShopHRM.Shared;
using System.Collections.Generic;

namespace CoffeeShopHRM.Api.Models
{
    public interface IEmployeeRepository
    {
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployeeById(int employeeId);
        Employee UpdateEmployee(Employee employee);
    }
}