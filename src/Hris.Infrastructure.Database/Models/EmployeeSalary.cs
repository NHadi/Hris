using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeSalary
    {
        public Guid EmployeeSalaryId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string BasicSalary { get; set; }
        public string PositionAllowance { get; set; }
        public string AttendanceAllowance { get; set; }
        public string MealAllowance { get; set; }
        public string TransportAllowance { get; set; }
        public string PlacementAllowance { get; set; }
        public string BbmAllowance { get; set; }
        public string TelecommunicationAllowance { get; set; }
        public string PlaceAllowance { get; set; }
        public string FunctionalAllowance { get; set; }

        public virtual Employee Employee { get; set; }
    }
}