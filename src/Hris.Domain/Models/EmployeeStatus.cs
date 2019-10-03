using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeStatus
    {
        public EmployeeStatus()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid EmployeeStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string EmployeeStatusCode { get; set; }
        public string EmployeeStatusName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}