using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class TaxRate
    {
        public int TaxRateId { get; set; }
        public double? RatePercent { get; set; }
        public double? FromAmount { get; set; }
        public double? ToAmount { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }
    }
}