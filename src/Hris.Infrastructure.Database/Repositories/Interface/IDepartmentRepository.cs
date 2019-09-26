using Hris.Common.Repositories.Interface;
using Hris.Infrastructure.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Infrastructure.Database.Repositories.Interface
{
    public interface IDepartmentRepository : IEfRepository<Department>
    {
    }
}
