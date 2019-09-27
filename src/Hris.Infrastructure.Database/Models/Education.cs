using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Education : EntityBase
    {
        public Education()
        {
            Employee = new HashSet<Employee>();
            EmployeeFamily = new HashSet<EmployeeFamily>();
        }

        public Guid EducationId { get; set; }
        public string EducationCode { get; set; }
        public string EducationName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<EmployeeFamily> EmployeeFamily { get; set; }
    }
}