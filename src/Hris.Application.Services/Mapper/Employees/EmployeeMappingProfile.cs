using AutoMapper;
using Hris.Domain.Aggregates.Master;
using Hris.Domain.Models;

namespace Hris.Application.Services.Mapper.Employees
{
    public partial class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DepartmentRequest, Department>();
        }
    }
}
