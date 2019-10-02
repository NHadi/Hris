using Hris.Common;
using Hris.Common.Repositories;
using Hris.Common.Repositories.Interface;
using Hris.Domain.master;
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

        public async Task<IEnumerable<DepartmentDto>> GetDepartmentByKey(string key = null)
        {
            var qry = "SELECT * FROM department ";

            if (key != null)
                qry += "where DepartmentCode like @keyword or DepartmentName like @keyword ";

            var result = await new DapperRepository<DepartmentDto>(_dbContextFactory.GetDbConnection(Global.DbConnection.HrisConnection))
                            .FromSqlAsync(qry, new { keyword = "%" + key + "%" });

            return result;
        }
    }
}
