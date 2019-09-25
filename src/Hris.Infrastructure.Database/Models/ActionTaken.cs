using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class ActionTaken
    {
        public ActionTaken()
        {
            Punishment = new HashSet<Punishment>();
        }

        public int ActionTakenId { get; set; }
        public string ActionTakenCode { get; set; }
        public string ActionTakenName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Punishment> Punishment { get; set; }
    }
}