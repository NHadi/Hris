using AutoMapper;
using Hris.Application.Services.Dto.Master;
using Hris.Infrastructure.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
