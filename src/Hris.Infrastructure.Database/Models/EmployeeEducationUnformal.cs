﻿using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class EmployeeEducationUnformal
    {
        public int EmployeeEducationUnformalId { get; set; }
        public int EmployeeId { get; set; }
        public string CourseType { get; set; }
        public string Object { get; set; }
        public string HeldBy { get; set; }
        public DateTime? From { get; set; }
        public DateTime? Until { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? Deleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}