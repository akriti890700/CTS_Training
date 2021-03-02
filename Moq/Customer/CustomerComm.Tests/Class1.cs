using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCommLib;
using NUnit.Framework;
using Moq;

namespace CustomerCommTests
{
    [TestFixture]
    public class Class1
    {
        Mock<IMailSender> mockMailSender;

        CustomerComm custTest;

        [Test]
        public void TestMethod()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(x => x.SendMail("cust123@abc.com", "Some Message")).Returns(true);

            custTest = new CustomerComm(mockMailSender.Object);
            var result = custTest.SendMailToCustomer();

            Assert.AreEqual(true,result);
        }
    }
}
