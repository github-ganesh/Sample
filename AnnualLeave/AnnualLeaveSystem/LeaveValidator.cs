using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.AnnualLeaveSystem
{
    /// <summary>
    /// Validate Leave application
    /// </summary>
    public class LeaveValidator:ILeaveValidator
    {
        #region public methods
        public bool Validate(DateTime startDate, int numberOfDays, IEmployee employee, IEnumerable<IPolicy> policies)
        {
            if (numberOfDays <= 0)
                throw new ArgumentException(string.Format("Invalid parameter value applied leave -{0}", numberOfDays));
            if (employee == null)
                throw new ArgumentNullException("Employee object is null");
            if (policies == null)
                throw new ArgumentNullException("policies object is null");

            // Get policy for married employee
            // Get policy for Male employee
            // Get policy based on type of employment 
            // .... so on
            var applicablePolicies = policies.Where(x => x.IsApplicableForMarriedEmployee == employee.IsMarried);
            if(!applicablePolicies.Any())
            {
                throw new LeaveValidationException("No policy matching for this employee");
            }
            // different classes can be used for validating different conditions
            foreach (IPolicy policy in applicablePolicies)
            {
                if (policy.TotalLeaves <= numberOfDays)
                    throw new LeaveValidationException("Policy has less number of leave than applied");

                if (policy.IsProbationaryLeaveApplicable && (DateTime.Now - employee.ContactStartDate).TotalDays <= 90)
                    throw new LeaveValidationException("Policy doesn't support leaves in probationary period");

                if (policy.MaxConsecutiveLeave <= numberOfDays)
                    throw new LeaveValidationException(string.Format("Policy not support more than {0} consecutive leave", policy.MaxConsecutiveLeave));
            }
            return true;
        }
        #endregion

    }
}
