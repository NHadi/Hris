using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Asset
    {
        public Asset()
        {
            EmployeeAsset = new HashSet<EmployeeAsset>();
        }

        public Guid AssetId { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<EmployeeAsset> EmployeeAsset { get; set; }
    }
}