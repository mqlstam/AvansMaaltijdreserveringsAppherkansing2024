using System.Collections.Generic;
using System.Threading.Tasks;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}