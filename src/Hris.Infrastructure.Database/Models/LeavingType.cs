using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class LeavingType : EntityBase
    {
        public LeavingType()
        {
            LeavingRequest = new HashSet<LeavingRequest>();
        }

        public Guid LeavingTypeId { get; set; }
        public string LeavingTypeCode { get; set; }
        public string LeavingTypeName { get; set; }
        public bool? LeavingDeduction { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<LeavingRequest> LeavingRequest { get; set; }
    }
}