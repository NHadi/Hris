﻿using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class ActionTaken : EntityBase
    {
        public ActionTaken()
        {
            Punishment = new HashSet<Punishment>();
        }

        public Guid ActionTakenId { get; set; }        
        public string ActionTakenCode { get; set; }
        public string ActionTakenName { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Punishment> Punishment { get; set; }
    }
}