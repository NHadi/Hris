using AutoMapper;
using Hris.Application.Services.Dto.Master;
using Hris.Application.Services.Interface;
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

namespace Hris.Application.Services
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
