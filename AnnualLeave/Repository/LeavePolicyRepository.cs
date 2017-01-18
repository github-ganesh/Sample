using AnnualLeave.AnnualLeaveSystem;
using AnnualLeave.Common;
using System;
using System.Collections.Generic;
namespace AnnualLeave.Repository
{
    public class LeavePolicyRepository:ILeavePolicyRepository
    {
       
        #region public method
        public void Save(IAnnualLeave anualLeave) 
        {
            if(anualLeave == null)
            {
                throw new ArgumentNullException("anualLeave object is null");
            }
            // Save data in database
            if( anualLeave.Id == 0)
            {
                //Save new record in the database 
                
            }
            else
            {
                //Update existing record with new data
                //Policy date has to validated deleted and modified  - ( depending on the DB design )
            }

        }
        public List<IAnnualLeave> Get(int departmentId)
        {
            if(departmentId <=0)
                throw new ArgumentException(string.Format("departmentId :{0} is not valid ",departmentId ));

            // assumption -- Data will be fetched from the database with separate ORM
            // assumption -- Query the database and get the anualLeave for the selected department
            // assumption -- Database Query and fill Annual leave list

            return new List<IAnnualLeave>(){ new AnnualLeave.AnnualLeaveSystem.AnnualLeave(1, "Casual Leave", new List<IPolicy>()
                {
                    new Policy()
                    {
                        EmployeeType= EmployeeTypes.Permanent,
                        Gender= Gender.Male,
                        IsApplicableForMarriedEmployee= true,
                        IsProbationaryLeaveApplicable=true,
                        MaxConsecutiveLeave=12,
                        TotalLeaves=12
                        
                    },
                     new Policy()
                    {
                        EmployeeType= EmployeeTypes.Permanent,
                        Gender= Gender.Female,
                        IsApplicableForMarriedEmployee= true,
                        IsProbationaryLeaveApplicable=true,
                        MaxConsecutiveLeave=15,
                        TotalLeaves=12
                        
                    },
                     new Policy()
                    {
                        EmployeeType= EmployeeTypes.Contractor,
                        Gender= Gender.Female,
                        IsApplicableForMarriedEmployee= true,
                        IsProbationaryLeaveApplicable=false,
                        MaxConsecutiveLeave=6,
                        TotalLeaves=3
                        
                    }
                    // it can be dynamic list based on policies
                }
                )};
               

        }
        
        public void Remove(IAnnualLeave anualLeave) 
        {
            if(anualLeave == null)
            {
                throw new ArgumentNullException("anualLeave object is null");
            }
            // delete data in database
            // Delete all policy data and delete annual leave - ( depending on the DB design )
        }
        #endregion


    }
}
