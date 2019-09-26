using Hris.Infrastructure.Database.Models;
using Hris.Organization.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Organization.WebApi.Services.Interface
{
    public interface IEmployeeService
    {
        #region Department
        Task<Department> GetDepartment(Guid id);
        Task<List<Department>> GetDepartments(string key);
        Task CreateDepartment(DepartmentRequest request);
        #endregion
        #region Employee
        Task<Employee> GetEmployee(Guid id);
        Task<List<Employee>> GetEmployees(string key);
        Task CreateEmployee();
        #endregion

    }
}
