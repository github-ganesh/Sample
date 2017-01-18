using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    public class EmployeeLeaveRequest:IEmployeeLeaveRequest
    {
        #region properties
        public int EmployeeId { get; set; }
        public DateTime LeaveStartDateTime { get; set; }
        public DateTime LeaveEndDateTime { get; set; }
        public bool IsApproved { get; set; }
        #endregion

    }
}
