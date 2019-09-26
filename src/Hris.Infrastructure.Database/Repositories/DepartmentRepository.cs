using Hris.Common;
using Hris.Common.Repositories;
using Hris.Common.Repositories.Interface;
using Hris.Infrastructure.Database.Contexts;
using Hris.Infrastructure.Database.Models;
using Hris.Infrastructure.Database.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hris.Infrastructure.Database.Repositories
{
    public class DepartmentRepository : EfRepository<Department>, IDepartmentRepository
    {
        private readonly HrisContext _context;
        private readonly IDbContextFactory _dbContextFactory;
        public DepartmentRepository(HrisContext context, IDbContextFactory dbContextFactory) : base(context)
        {
            _context = context;
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Department>> GetDepartmentByCode(string code)
        {
            var result = await new DapperRepository<Department>(_dbContextFactory.GetDbConnection(Global.DbConnection.HrisConnection))
                            .FromSqlAsync("SELECT * FROM Department where department_code like @keyword", new { keyword = "%" + code + "%" });

            return result;
        }
    }
}
