using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TravellingType : EntityBase
    {
        public TravellingType()
        {
            TravellingExpense = new HashSet<TravellingExpense>();
        }

        public Guid TravellingTypeId { get; set; }        
        public string TravellingTypeCode { get; set; }
        public string TravellingTypeName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<TravellingExpense> TravellingExpense { get; set; }
    }
}