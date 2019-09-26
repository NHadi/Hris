using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeEducationFormal
    {
        public Guid EmployeeEducationFormalId { get; set; }
        public Guid EmployeeId { get; set; }
        public string LevelEducationName { get; set; }
        public string SchoolName { get; set; }
        public string Majors { get; set; }
        public DateTime? From { get; set; }
        public DateTime? Until { get; set; }
        public byte[] Gpa { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}