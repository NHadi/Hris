﻿using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int? EmployeeId { get; set; }
        public string FingerCode { get; set; }
        public int? DayTypeId { get; set; }
        public int? AbsenceTypeId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DefaultIn { get; set; }
        public DateTime? DefaultOut { get; set; }
        public DateTime? ActualIn { get; set; }
        public DateTime? ActualOut { get; set; }
        public DateTime? BreakIn { get; set; }
        public DateTime? BreakOut { get; set; }
        public TimeSpan? LateIn { get; set; }
        public TimeSpan? WorkHour { get; set; }
        public TimeSpan? EffectiveHour { get; set; }
        public string Description { get; set; }

        public virtual AbsenceType AbsenceType { get; set; }
        public virtual DayType DayType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}