using Hris.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Domain.Aggregates.Master.Interface
{
    public interface IMasterService
    {
        #region Department
        Task<Department> GetDepartment(Guid id);        
        Task<List<DepartmentDto>> GetDepartments(DepartmentRequest request);
        Task CreateDepartment(DepartmentRequest request);
        Task DeleteDepartment(Guid id);
        Task UpdateDepartment(Guid id, DepartmentRequest request);
        #endregion
    }
}
