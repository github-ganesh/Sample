using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Client
{
    /// <summary>
    /// Class Human Resource Department
    /// </summary>
    /// <seealso cref="AnnualLeave.Client.IHumanResourceDepartment" />
    public class HumanResourceDepartment:IHumanResourceDepartment
    {
        #region properties
        public string Name { get; set; }
        public int Id{ get; private set; }
        #endregion
    }
}
