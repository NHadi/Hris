using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class PermitRequest
    {
        public Guid PermitRequestId { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? PermitDate { get; set; }
        public Guid? EmployeeId { get; set; }
        public TimeSpan? FromHour { get; set; }
        public TimeSpan? UntilHour { get; set; }
        public string Description { get; set; }
        public string ReasonRejected { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}