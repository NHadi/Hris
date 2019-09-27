using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class PayrollType : EntityBase
    {
        public PayrollType()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid PayrollTypeId { get; set; }
        public string PayrollTypeName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}