using Hris.Application.Services.Dto.Master;
using Hris.Domain.master;
using Hris.Infrastructure.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Application.Services.Interface
{
    public interface IMasterService
    {
        Task<Department> GetDepartment(Guid id);
        Task<List<DepartmentDto>> GetDepartments(string key);
        Task CreateDepartment(DepartmentRequest request);
    }
}
