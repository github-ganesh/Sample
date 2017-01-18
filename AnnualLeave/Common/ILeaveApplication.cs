using AnnualLeave.AnnualLeaveSystem;
using AnnualLeave.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    /// <summary>
    /// Employee Leave application
    /// </summary>
    public interface ILeaveApplication
    {
        /// <summary>
        /// Gets or sets the employee leave request.
        /// </summary>
        /// <value>
        /// The employee leave request.
        /// </value>
        IEmployeeLeaveRequest EmployeeLeaveRequest { get;  }

        /// <summary>
        /// Gets or sets the annual leave policy.
        /// </summary>
        /// <value>
        /// The annual leave policy.
        /// </value>
        IAnnualLeave AnnualLeavePolicy { get;  }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        IEmployee Employee { get;  }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <returns></returns>
        bool Validate(ILeaveValidator leaveValidator);
       
    }
}
