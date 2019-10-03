using AutoMapper;
using Hris.Domain.Aggregates.Master;
using Hris.Domain.Models;

namespace Hris.Application.Services.Mapper.Employees
{
    public partial class MasterMappingProfile : Profile
    {
        public MasterMappingProfile()
        {
            CreateMap<DepartmentRequest, Department>()
                   .ForMember(dest => dest.DepartmentId, opt => opt.UseDestinationValue());
        }
    }
}
