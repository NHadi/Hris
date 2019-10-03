using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class AbsenceType
    {
        public AbsenceType()
        {
            Attendance = new HashSet<Attendance>();
        }

        public Guid AbsenceTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string AbsenceTypeCode { get; set; }
        public string AbsenceTypeName { get; set; }
        public bool? LeavingDeduction { get; set; }
        public bool? Present { get; set; }
        public bool? Alpha { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}