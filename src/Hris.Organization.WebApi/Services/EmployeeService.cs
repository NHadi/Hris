using Hris.Common.Repositories.Interface;
using Hris.Infrastructure.Database.Contexts;
using Hris.Infrastructure.Database.Models;
using Hris.Infrastructure.Database.Repositories.Interface;
using Hris.Organization.WebApi.Models;
using Hris.Organization.WebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hris.Organization.WebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork<HrisContext> _uow;
        private readonly IDepartmentRepository _departmentRepository;
        public EmployeeService(IDepartmentRepository departmentRepository, IUnitOfWork<HrisContext> uow)
        {
            _departmentRepository = departmentRepository;
            _uow = uow;
        }

        public async Task CreateDepartment(DepartmentRequest request)
        {
            
            try
            {
                _uow.BeginTransaction();

                var newData = new Department();
                newData.DepartmentId = Guid.NewGuid();
                newData.DepartmentCode = request.DepartmentCode;
                newData.DepartmentName = request.DepartmentName;
                newData.CreatedBy = "Dummy";
                newData.CreatedDate = DateTime.Now;

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

        public Task CreateEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartment(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetDepartments(string key)
        {
            var data = await _departmentRepository.GetAsync(x => x.DepartmentName.Contains(key) || x.DepartmentCode.Contains(key));
            return data.ToList();
        }
        

        public Task<Employee> GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployees(string key)
        {
            throw new NotImplementedException();
        }
    }
}
