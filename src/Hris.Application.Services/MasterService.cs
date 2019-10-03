using AutoMapper;
using Hris.Common.Repositories.Interface;
using Hris.Domain.Aggregates.Master;
using Hris.Domain.Aggregates.Master.Interface;
using Hris.Domain.Models;
using Hris.Infrastructure.Database.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Application.Services.Master
{
    public class MasterService : IMasterService
    {
        private readonly IUnitOfWork<HrisContext> _uow;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public MasterService(IUnitOfWork<HrisContext> uow,
            IMapper mapper,
            IDepartmentRepository departmentRepository
            )
        {
            _uow = uow;
            _mapper = mapper;
            _departmentRepository = departmentRepository;            
        }
        public async Task CreateDepartment(DepartmentRequest request)
        {

            try
            {
                _uow.BeginTransaction();

                var newData = _mapper.Map<Department>(request);
                newData.DepartmentId = Guid.NewGuid();
                newData.CreatedBy = "Dummy";

                _departmentRepository.Insert(newData);
                _uow.CommitTransaction();

                await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                _uow.RollbackTransaction();
                throw ex;
            }
        }

        public Task<Department> GetDepartment(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DepartmentDto>> GetDepartments(string key)
        {
          var data = await _departmentRepository.GetDepartmentByKey(key);
          return data.ToList();
        }
    }
}
