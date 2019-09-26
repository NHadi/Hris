using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeAsset
    {
        public Guid EmployeeAssetId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid? AssetId { get; set; }
        public DateTime? LendDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Employee Employee { get; set; }
    }
}