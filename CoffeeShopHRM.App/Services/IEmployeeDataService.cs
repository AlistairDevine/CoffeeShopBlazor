using CoffeeShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeeShopHRM.App.Services
{
    public interface IEmployeeDataService
    {
        Task<Employee> AddEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
        Task UpdateEmployee(Employee employee);
    }
}