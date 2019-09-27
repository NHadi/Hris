using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class MedicalReimbursement : EntityBase
    {
        public Guid MedicalReimbursementId { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? MedicalTypeId { get; set; }
        public DateTime? DateMedical { get; set; }
        public string PatientName { get; set; }
        public double? ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }        
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual MedicalType MedicalType { get; set; }
    }
}