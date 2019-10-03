using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeSkill
    {
        public Guid EmployeeSkillId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid EmployeeId { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}