using Hris.Application.Services.Interface;
using Hris.Infrastructure.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task CreateEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployees(string key)
        {
            throw new NotImplementedException();
        }
    }
}
