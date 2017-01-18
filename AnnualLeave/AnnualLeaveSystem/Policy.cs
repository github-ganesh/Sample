using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.AnnualLeaveSystem
{
   public  class Policy:IPolicy
   {
       #region properties
       public int TotalLeaves{get;set;}

       public bool IsProbationaryLeaveApplicable { get; set; }

        public EmployeeTypes EmployeeType { get; set; }

        public int MaxConsecutiveLeave { get; set; }

        public Gender Gender { get; set; }

        public bool IsApplicableForMarriedEmployee { get; set; }
       #endregion
   }
}
