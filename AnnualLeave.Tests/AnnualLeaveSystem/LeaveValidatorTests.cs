using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnualLeave.AnnualLeaveSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnnualLeave.Common;
namespace AnnualLeave.Tests
{
    [TestClass()]
    public class LeaveValidatorTests
    {
        [TestMethod()]
        public void ValidateTest()
        {
            ILeaveValidator target = new LeaveValidator();

            Assert.IsTrue(target.Validate(DateTime.Now, 5,GetMockEmployee(), GetMockPolicy(10,5)));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid parameter value applied leave --1")]
        public void ValidateTestException1()
        {
            ILeaveValidator target = new LeaveValidator();

            target.Validate(DateTime.Now, -1, GetMockEmployee(), GetMockPolicy(12, 6));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "employee object cannot be null")]
        public void ValidateTestException2()
        {
            ILeaveValidator target = new LeaveValidator();

            target.Validate(DateTime.Now, 8, null, GetMockPolicy(12, 6));
        }
        [TestMethod]
        [ExpectedException(typeof(LeaveValidationException), "Applied leaves more than the policy annual leave limit")]
        public void ValidateTestException3()
        {
            ILeaveValidator target = new LeaveValidator();

            target.Validate(DateTime.Now, 30, GetMockEmployee(), GetMockPolicy(12, 6));
        }

        private IEmployee GetMockEmployee()
        {
            var emp =new Moq.Mock<IEmployee>();
            emp.SetupGet(x => x.Name).Returns("Test Employee1");
            emp.SetupGet(x => x.IsMarried).Returns(true);
            emp.SetupGet(x => x.EmployeeId).Returns(100);
            return emp.Object;
        }
        private List<IPolicy> GetMockPolicy(int totalLeaves, int maxConsecutiveLeave)
        {
            var policy = new Moq.Mock<IPolicy>();
            List<IPolicy> list=new List<IPolicy>();
            list.Add(policy.Object);
            policy.SetupGet(x => x.EmployeeType).Returns(EmployeeTypes.Permanent);
            policy.SetupGet(x => x.Gender).Returns(Gender.Male);
            policy.SetupGet(x => x.IsProbationaryLeaveApplicable).Returns(true);
            policy.SetupGet(x => x.MaxConsecutiveLeave).Returns(6);
            policy.SetupGet(x => x.TotalLeaves).Returns(10);
            policy.SetupGet(x => x.IsApplicableForMarriedEmployee).Returns(true);
            return list;
        }
    }
}
