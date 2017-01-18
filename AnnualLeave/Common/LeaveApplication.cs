using AnnualLeave.AnnualLeaveSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    public class LeaveApplication:ILeaveApplication
    {
        #region public methods
        public LeaveApplication(IEmployeeLeaveRequest employeeLeaveRequest, IAnnualLeave anualLeave, IEmployee employee)
        {
            EmployeeLeaveRequest= employeeLeaveRequest;
            AnnualLeavePolicy = anualLeave;
            Employee = employee;
        }
        public IEmployeeLeaveRequest EmployeeLeaveRequest { get; private set; }
        public IAnnualLeave AnnualLeavePolicy { get; private set; }
        public IEmployee Employee { get; private set; }
        public bool Validate(ILeaveValidator leaveValidator)
        {
            if (leaveValidator == null)
                throw new ArgumentNullException("leaveValidator is null");

            return leaveValidator.Validate(EmployeeLeaveRequest.LeaveStartDateTime, (EmployeeLeaveRequest.LeaveEndDateTime - EmployeeLeaveRequest.LeaveStartDateTime).Days, Employee, AnnualLeavePolicy.Policies);
        }
        #endregion
    }
}
