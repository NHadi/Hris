using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class Department
    {
        public Department()
        {
            Division = new HashSet<Division>();
            Employee = new HashSet<Employee>();
        }

        public Guid DepartmentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Division> Division { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}