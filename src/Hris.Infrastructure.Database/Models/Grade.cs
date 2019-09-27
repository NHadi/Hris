using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Grade : EntityBase
    {
        public Grade()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid GradeId { get; set; }
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}