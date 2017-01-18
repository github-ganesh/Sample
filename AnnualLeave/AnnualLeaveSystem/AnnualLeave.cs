using AnnualLeave.Client;
using AnnualLeave.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnnualLeave.AnnualLeaveSystem
{
    /// <summary>
    /// Casual Annual Leave
    /// </summary>
    /// <seealso cref="AnnualLeave.AnualLeaveSystem.IAnualLeave"/>
    public class AnnualLeave : IAnnualLeave
    {
        #region properties

        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<IPolicy> Policies { get; set; }
        public int DepartmentId { get; private set; }
        #endregion

        #region constructor
        public AnnualLeave(int id, string name, List<IPolicy> policies)
        {
            Name = name;
            Policies = policies;
        }

        #endregion

      }
}
