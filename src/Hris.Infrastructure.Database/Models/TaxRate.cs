using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class TaxRate : EntityBase
    {
        public Guid TaxRateId { get; set; }
        public double? RatePercent { get; set; }
        public double? FromAmount { get; set; }
        public double? ToAmount { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }
    }
}