using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class MedicalType
    {
        public MedicalType()
        {
            MedicalReimbursement = new HashSet<MedicalReimbursement>();
        }

        public Guid MedicalTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string MedicalTypeCode { get; set; }
        public string MedicalTypeName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<MedicalReimbursement> MedicalReimbursement { get; set; }
    }
}