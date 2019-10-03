using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TrainingType : EntityBase
    {
        public TrainingType()
        {
            Training = new HashSet<Training>();
        }

        public Guid TrainingTypeId { get; set; }        
        public string TrainingTypeCode { get; set; }
        public string TrainingTypeName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Training> Training { get; set; }
    }
}