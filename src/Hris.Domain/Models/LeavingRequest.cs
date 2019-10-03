using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class LeavingRequest : EntityBase
    {
        public Guid LeavingRequestId { get; set; }        
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? LeavingTypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public int? Days { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ReasonRejected { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual LeavingType LeavingType { get; set; }
    }
}