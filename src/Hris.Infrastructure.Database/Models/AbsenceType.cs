using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class AbsenceType : EntityBase
    {
        public AbsenceType()
        {
            Attendance = new HashSet<Attendance>();
        }

        public Guid AbsenceTypeId { get; set; }
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