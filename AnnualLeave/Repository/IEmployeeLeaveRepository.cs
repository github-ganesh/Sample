using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Repository
{
    public interface IEmployeeLeaveRepository
    {
        void Remove(ILeaveApplication leaveApplication);
        void Save(ILeaveApplication leaveApplication);
        List<ILeaveApplication> Get(int employeeId);
        
    }
    public class EmployeeLeaveRepository:IEmployeeLeaveRepository
    {
        // this class implementation is similar to LeavePolicyRepository
        //1. Exception 
        //2. DB query 

        public void Remove(ILeaveApplication leaveApplication) { }
        public void Save(ILeaveApplication leaveApplication) { }
        public List<ILeaveApplication> Get(int employeeId) { return null; }

    }
}
