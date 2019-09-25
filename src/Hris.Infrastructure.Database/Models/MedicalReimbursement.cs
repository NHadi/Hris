﻿using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class MedicalReimbursement
    {
        public int MedicalReimbursementId { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? MedicalTypeId { get; set; }
        public DateTime? DateMedical { get; set; }
        public string PatientName { get; set; }
        public double? ClaimAmount { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual MedicalType MedicalType { get; set; }
    }
}