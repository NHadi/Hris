using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class PayrollType
    {
        public PayrollType()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid PayrollTypeId { get; set; }
        public string PayrollTypeName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}