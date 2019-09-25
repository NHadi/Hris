using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class DayType
    {
        public DayType()
        {
            Attendance = new HashSet<Attendance>();
            Employee = new HashSet<Employee>();
        }

        public int DayTypeId { get; set; }
        public string DayTypeName { get; set; }
        public TimeSpan? DefaultIn { get; set; }
        public TimeSpan? DefaultOut { get; set; }
        public TimeSpan? FridayIn { get; set; }
        public TimeSpan? FridayOut { get; set; }
        public TimeSpan? SaturdayIn { get; set; }
        public TimeSpan? SaturdayOut { get; set; }
        public TimeSpan? SundayIn { get; set; }
        public TimeSpan? SundayOut { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}