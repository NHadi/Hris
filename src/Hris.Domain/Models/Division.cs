using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class Division
    {
        public Division()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid DivisionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid DepartmentId { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}