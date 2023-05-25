using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto: BaseDTOs
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
