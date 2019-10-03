using Hris.Common.Domain;
using System;
using System.Collections.Generic;

namespace Hris.Domain.Models
{
    public partial class DayType : EntityBase
    {
        public DayType()
        {
            Attendance = new HashSet<Attendance>();
            Employee = new HashSet<Employee>();
        }

        public Guid DayTypeId { get; set; }        
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
        public bool? Deleted { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
    }
}