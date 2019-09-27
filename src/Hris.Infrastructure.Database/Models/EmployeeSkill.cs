using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeSkill : EntityBase
    {
        public Guid EmployeeSkillId { get; set; }
        public Guid EmployeeId { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}