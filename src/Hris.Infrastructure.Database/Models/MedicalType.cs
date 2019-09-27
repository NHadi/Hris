using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class MedicalType : EntityBase
    {
        public MedicalType()
        {
            MedicalReimbursement = new HashSet<MedicalReimbursement>();
        }

        public Guid MedicalTypeId { get; set; }
        public string MedicalTypeCode { get; set; }
        public string MedicalTypeName { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual ICollection<MedicalReimbursement> MedicalReimbursement { get; set; }
    }
}