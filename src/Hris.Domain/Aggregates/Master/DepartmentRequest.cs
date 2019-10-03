using System;
using System.Collections.Generic;
using System.Text;

namespace Hris.Domain.Aggregates.Master
{
    public class DepartmentRequest
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
    }
}
