using Hris.Infrastructure.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Application.Services.Interface
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployee(Guid id);
        Task<List<Employee>> GetEmployees(string key);
        Task CreateEmployee();
    }
}
