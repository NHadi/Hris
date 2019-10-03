using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeExperience
    {
        public Guid EmployeeExperienceId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? Until { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string BusinessType { get; set; }
        public string LastPosition { get; set; }
        public double? LastSalary { get; set; }
        public string ReasonSeparation { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}