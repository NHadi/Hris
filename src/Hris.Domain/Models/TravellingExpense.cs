using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class TravellingExpense : EntityBase
    {
        public Guid TravellingExpenseId { get; set; }        
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? TravellingTypeId { get; set; }
        public string Destination { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TravellingType TravellingType { get; set; }
    }
}