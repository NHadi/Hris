using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class TravellingExpense
    {
        public int TravellingExpenseId { get; set; }
        public string NoTransaction { get; set; }
        public DateTime? Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? TravellingTypeId { get; set; }
        public string Destination { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? UntilDate { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual TravellingType TravellingType { get; set; }
    }
}