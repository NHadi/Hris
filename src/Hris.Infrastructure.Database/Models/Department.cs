using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Department : EntityBase
    {
        public Department()
        {
            Division = new HashSet<Division>();
            Employee = new HashSet<Employee>();
        }

        public Guid DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<Division> Division { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}