using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class Asset : EntityBase
    {
        public Asset()
        {
            EmployeeAsset = new HashSet<EmployeeAsset>();
        }

        public Guid AssetId { get; set; }        
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<EmployeeAsset> EmployeeAsset { get; set; }
    }
}