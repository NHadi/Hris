using Dapper;
using Hris.Common;
using Hris.Common.Repositories;
using Hris.Common.Repositories.Interface;
using Hris.Domain.Aggregates.Master;
using Hris.Domain.Aggregates.Master.Interface;
using Hris.Domain.Models;
using Hris.Infrastructure.Database.Contexts;
using System.Collections.Generic;
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

        public async Task<IEnumerable<DepartmentDto>> GetDepartmentByKey(DepartmentRequest request)
        {
            var qry = $@"SELECT * FROM department 
                        where Deleted = 0 
                        {(!string.IsNullOrEmpty(request.DepartmentCode) ? "and DepartmentCode like @code" : "")}
                        {(!string.IsNullOrEmpty(request.DepartmentName) ? "and DepartmentName like @name" : "")}
                        {(!string.IsNullOrEmpty(request.Description) ? "and Description like @description" : "")}                        
                    ";

            var param = new DynamicParameters();
            param.Add("@code", "%" + request.DepartmentCode + "%");
            param.Add("@name", "%" + request.DepartmentName + "%");
            param.Add("@description", "%" + request.Description + "%");

            var result = await new DapperRepository<DepartmentDto>(_dbContextFactory.GetDbConnection(Global.DbConnection.HrisConnection))
                            .FromSqlAsync(qry, param);

            return result;
        }
    }
}
