using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Training : EntityBase
    {
        public Guid TrainingId { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? TrainingTypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public string Subject { get; set; }
        public string Fasilitator { get; set; }
        public string Provider { get; set; }
        public string Instructure { get; set; }
        public bool? Certified { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TrainingType TrainingType { get; set; }
    }
}