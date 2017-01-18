using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.AnnualLeaveSystem
{
    /// <summary>
    /// Validate leave application
    /// </summary>
    public interface ILeaveValidator
    {
        /// <summary>
        /// Validates the specified leave application.
        /// </summary>
        /// <param name="startDate">The leave start date.</param>
        /// <param name="numberOfDays">The number of days leave applied.</param>
        /// <param name="employee">The employee.</param>
        /// <param name="policies">The policies.</param>
        bool Validate(DateTime startDate, int numberOfDays, IEmployee employee, IEnumerable<IPolicy> policies);
    }
   
}
