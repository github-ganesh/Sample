using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnnualLeave.Common
{
    /// <summary>
    /// Employee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The Employee identifier.
        /// </value>
        int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the contact start date.
        /// </summary>
        /// <value>
        /// The contact start date.
        /// </value>
        DateTime ContactStartDate { get; set; }
        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        decimal? Salary { get; set; }
        /// <summary>
        /// Gets or sets a value married status.
        /// </summary>
        /// <value>
        /// <c>true</c> if this employee is married; otherwise, <c>false</c>.
        /// </value>
        bool IsMarried { get; set; }
    }
}
