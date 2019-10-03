using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class LeaveRemaining
    {
        public Guid LeaveRemainingId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid? EmployeeId { get; set; }
        public int? Year { get; set; }
        public int? Plafon { get; set; }
        public int? Used { get; set; }
        public int? AdjLeave { get; set; }
        public int? Remaining { get; set; }
        public string Description { get; set; }

        public virtual Employee Employee { get; set; }
    }
}