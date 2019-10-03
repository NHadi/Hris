using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TaxRate
    {
        public Guid TaxRateId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public double? RatePercent { get; set; }
        public double? FromAmount { get; set; }
        public double? ToAmount { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }
    }
}