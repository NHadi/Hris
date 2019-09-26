using Hris.Common.Repositories;
using Hris.Infrastructure.Database.Contexts;
using Hris.Infrastructure.Database.Models;
using Hris.Infrastructure.Database.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Infrastructure.Database.Repositories
{
    public class DepartmentRepository : EfRepository<Department>, IDepartmentRepository
    {
        private readonly HrisContext _context;
        public DepartmentRepository(HrisContext context) : base(context)
        {
            _context = context;
        }
    }
}
