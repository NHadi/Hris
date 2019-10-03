using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TaxStatus : EntityBase
    {
        public TaxStatus()
        {
            Employee = new HashSet<Employee>();
        }

        public Guid TaxStatusId { get; set; }        
        public string TaxStatusName { get; set; }
        public double? Ptkp { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}