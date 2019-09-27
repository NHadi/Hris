using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeStatus : EntityBase
    {
        public EmployeeStatus()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid EmployeeStatusId { get; set; }
        public string EmployeeStatusCode { get; set; }
        public string EmployeeStatusName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}