using AnnualLeave.AnnualLeaveSystem;
using AnnualLeave.Common;
using AnnualLeave.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Client
{
    public class MainClass
    {
        IHumanResourceDepartment softWareHRDepartment = new HumanResourceDepartment();
        ILeavePolicyRepository policyrepository = new LeavePolicyRepository();
        List<IAnnualLeave> softwareDepartmentAnnualLeavePolicy;
        IEmployeeLeaveRepository employeeLeaveRepository;// = new EmployeeLeaveRepository();

        public MainClass()
        {
            // assumption -- while showing the UI all annual leave policy will be displayed in the UI
            // assumption -- user can filter leave policy based on employee data ( employee gender , employee type etc)

            //Get  leave policy 
            softwareDepartmentAnnualLeavePolicy = GetLeavePolicy(softWareHRDepartment.Id);
        }
        public void ApplyLeave()
        {
            var leaveApplication = GetLeaveApplication();
            if (leaveApplication== null)
            {
                // use logger -- exception and call stack
                // use related message to user... 
            }
            // assumption -- before leave policy validation current leave application will be validate with existing applied leaves (accumulated casual leaves / available casual leaves)
            Validate(leaveApplication); // validates only the selected leave policy 
            SaveLeaveApplication(leaveApplication);
        }
        // assumption -- user will select start date - end date - Annual leave type -- from the UI
        private ILeaveApplication GetLeaveApplication()
        {
            try
            {
                //assumption -- user select leave policy from the UI
                IAnnualLeave casualLeave = softwareDepartmentAnnualLeavePolicy[0];
                return new LeaveApplication(new AnnualLeave.Common.EmployeeLeaveRequest() { EmployeeId = 1, IsApproved = false, LeaveStartDateTime = DateTime.Now, LeaveEndDateTime = DateTime.Now.AddDays(3) },
                    casualLeave, new AnnualLeave.Common.Employee());
            }
            // catch specific exception
            catch (Exception ex)
            {
                // ues logger  -- exception and call stack
                // show generic message to user...
            }
            return null;
        }
        /// <summary>
        /// Submit Leave.
        /// </summary>
        /// <param name="leaveApplication">The leave application.</param>
        private void Validate(ILeaveApplication leaveApplication)
        {
            try
            {
                // assumption --  LeaveValidator good to separate dll - class can injected at runtime 
                // assumption -- it can be made array of LeaveValidator or object holding array
                if (leaveApplication.Validate(new LeaveValidator()))
                {
                    // use logger -- log success message
                    // show success message to user
                }
            }
            catch (ArgumentNullException anex)
            {
                // use logger -- exception and call stack
                // use related message to user...
            }
            catch(ArgumentException aex)
            {
                // use logger  -- exception and call stack
                // use related message to user...
            }
            catch (LeaveValidationException lvex)
            {
                // use logger  -- exception and call stack
                // show specific message to user...
            }
            catch (Exception ex)
            {
                // use logger  -- exception and call stack
                // show generic message to user...
            }
           
        }

        private void SaveCasualLeave(IHumanResourceDepartment humanResourceDepartment)
        {
            try
            {
                var casualLeave = new AnnualLeave.AnnualLeaveSystem.AnnualLeave(1, "Casual Leave", new List<IPolicy> { new Policy() });
                policyrepository.Save(casualLeave);
            }
            catch(ArgumentNullException aex)// specific exception
            {
                // use logger -- exception and call stack
                // use related message to user...
            }
            catch(Exception ex)
            {
                // use logger -- exception and call stack
                // show generic message to user...
            }

        }
       
        private void SaveLeaveApplication(ILeaveApplication leaveApplication)
        {
            try
            {
                employeeLeaveRepository.Save(leaveApplication);
            }
            catch (ArgumentNullException aex)// specific exception
            {
                // use logger -- exception and call stack
                // use related message to user...
            }
            catch (Exception ex)
            {
                // use logger -- exception and call stack
                // show generic message to user...
            }

           
        }

        private List<IAnnualLeave> GetLeavePolicy(int Id)
        {
            return policyrepository.Get(Id);
        }

    }
}
