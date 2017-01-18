using AnnualLeave.Client;
using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.AnnualLeaveSystem
{
    /// <summary>
    /// Annual leave 
    /// </summary>
    public interface IAnnualLeave
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; }

        /// <summary>
        /// Gets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        int DepartmentId { get; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets or sets the policies.
        /// </summary>
        /// <value>
        /// The policies.
        /// </value>
        List<IPolicy> Policies { get; }

    }
}
