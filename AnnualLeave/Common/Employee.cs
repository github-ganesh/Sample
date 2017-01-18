using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    public class Employee:IEmployee
    {
        #region properties
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime ContactStartDate { get; set; }
        public decimal? Salary { get; set; }
        public bool IsMarried { get; set; }
        #endregion
    }
}
