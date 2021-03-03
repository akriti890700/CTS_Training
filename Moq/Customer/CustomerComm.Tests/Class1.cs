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
        [OneTimeSetUp]
        public void init()
        {
            mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        }

        [Test]
        public void TestMethod()
        {   
            custTest = new CustomerComm(mockMailSender.Object);
            var result = custTest.SendMailToCustomer();

            Assert.AreEqual(true,result);
        }
    }
}
