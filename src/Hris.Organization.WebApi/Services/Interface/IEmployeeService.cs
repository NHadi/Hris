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
        Department GetDepartment(int id);
        List<Department> GeteDepartments(DepartmentRequest request);
        #endregion
    }
}
