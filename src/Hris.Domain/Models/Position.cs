using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class Position : EntityBase
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid PositionId { get; set; }        
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
        public int? PositionLevel { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}