using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeEducationUnformal : EntityBase
    {
        public Guid EmployeeEducationUnformalId { get; set; }        
        public Guid EmployeeId { get; set; }
        public string CourseType { get; set; }
        public string Object { get; set; }
        public string HeldBy { get; set; }
        public DateTime? From { get; set; }
        public DateTime? Until { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}