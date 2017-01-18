using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeave.Common
{
    /// <summary>
    /// Leave validation exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LeaveValidationException:Exception
    {
        #region public methods
        public LeaveValidationException(string message) : base(message) { }
        #endregion
    }
}
