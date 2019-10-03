﻿using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TrainingType
    {
        public TrainingType()
        {
            Training = new HashSet<Training>();
        }

        public Guid TrainingTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string TrainingTypeCode { get; set; }
        public string TrainingTypeName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Training> Training { get; set; }
    }
}