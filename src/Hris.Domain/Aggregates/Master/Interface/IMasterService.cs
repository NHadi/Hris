using Hris.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Domain.Aggregates.Master.Interface
{
    public interface IMasterService
    {
        Task<Department> GetDepartment(Guid id);
        Task<List<DepartmentDto>> GetDepartments(string key);
        Task CreateDepartment(DepartmentRequest request);
    }
}
