using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid EmployeeTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}