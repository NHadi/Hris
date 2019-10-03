using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class EmployeeFamily : EntityBase
    {
        public Guid EmployeeFamilyId { get; set; }        
        public Guid? EmployeeId { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Birthplace { get; set; }
        public Guid EducationId { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Education Education { get; set; }
        public virtual Employee Employee { get; set; }
    }
}