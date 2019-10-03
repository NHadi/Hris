using Hris.Common.Repositories.Interface;
using Hris.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hris.Domain.Aggregates.Master.Interface
{
    public interface IDepartmentRepository : IEfRepository<Department>
    {
        Task<IEnumerable<DepartmentDto>> GetDepartmentByKey(string key);
    }
}
