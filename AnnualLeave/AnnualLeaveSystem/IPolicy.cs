using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnualLeave.Common;

namespace AnnualLeave.AnnualLeaveSystem
{

    // assumption -- based on requirements properties will be added / deleted ( this entries similar to database entries)

    /// <summary>
    /// Leave policy
    /// </summary>
    public interface IPolicy
    {
        /// <summary>
        /// Gets or sets the total leaves.
        /// </summary>
        /// <value>
        /// The total leaves.
        /// </value>
        int TotalLeaves{get;set;}

        /// <summary>
        /// Gets or sets a value indicating whether this policy allow probationary leave.
        /// </summary>
        /// <value>
        /// <c>true</c> in this policy  probationary leave applicable; otherwise, <c>false</c>.
        /// </value>
        bool IsProbationaryLeaveApplicable { get; set; }

        /// <summary>
        /// Gets or sets the type of the employee.
        /// </summary>
        /// <value>
        /// The type of the employee.
        /// </value>
        EmployeeTypes EmployeeType{get;set;}

        /// <summary>
        /// Gets or sets the maximum consecutive leave.
        /// </summary>
        /// <value>
        /// The maximum consecutive leave.
        /// </value>
        int MaxConsecutiveLeave { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        Gender Gender{set;get;}

        /// <summary>
        /// Gets or sets a value indicating whether this instance is applicable for married employee.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is applicable for married employee; otherwise, <c>false</c>.
        /// </value>
        bool IsApplicableForMarriedEmployee { get; set; }
    }
}
