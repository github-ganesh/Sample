using AnnualLeave.AnnualLeaveSystem;
using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AnnualLeave.Repository
{
    /// <summary>
    /// Leave policy repository
    /// </summary>
    interface ILeavePolicyRepository
    {
        
        /// <summary>
        /// Saves the specified leave application.
        /// </summary>
        /// <param name="leaveApplication">The leave application.</param>
        void Save(IAnnualLeave anualLeave);

        /// <summary>
        /// Gets the specified department identifier.
        /// </summary>
        /// <param name="departmentId">The department identifier.</param>
        /// <returns></returns>
        List<IAnnualLeave> Get(int departmentId);

        /// <summary>
        /// Removes this instance.
        /// </summary>
        void Remove(IAnnualLeave anualLeave);


    }
}
