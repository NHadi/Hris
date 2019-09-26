using Hris.Infrastructure.Database.Models;
using Hris.Organization.WebApi.Models;
using Hris.Organization.WebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Organization.WebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Department GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GeteDepartments(DepartmentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
