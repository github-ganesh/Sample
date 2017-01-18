using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    /// <summary>
    /// Employee leave request
    /// </summary>
    public interface IEmployeeLeaveRequest
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        int EmployeeId { get; set; }
        /// <summary>
        /// Gets or sets the leave start date time.
        /// </summary>
        /// <value>
        /// The leave start date time.
        /// </value>
        DateTime LeaveStartDateTime { get; set; }
        /// <summary>
        /// Gets or sets the leave end date time.
        /// </summary>
        /// <value>
        /// The leave end date time.
        /// </value>
        DateTime LeaveEndDateTime { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is approved.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is approved; otherwise, <c>false</c>.
        /// </value>
        bool IsApproved { get; set; }
    }
}
