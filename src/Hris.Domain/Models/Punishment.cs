using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class Punishment
    {
        public Guid PunishmentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? ActionTakenId { get; set; }
        public DateTime? ValidDate { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ActionTaken ActionTaken { get; set; }
        public virtual Employee Employee { get; set; }
    }
}