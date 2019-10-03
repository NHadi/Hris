using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class LeavingType
    {
        public LeavingType()
        {
            LeavingRequest = new HashSet<LeavingRequest>();
        }

        public Guid LeavingTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string LeavingTypeCode { get; set; }
        public string LeavingTypeName { get; set; }
        public bool? LeavingDeduction { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<LeavingRequest> LeavingRequest { get; set; }
    }
}