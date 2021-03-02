using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace PlayerManagerTests
{
    [TestFixture]
    public class Class1
    {
        Mock<IPlayerMapper> mockPlayerMapper;
        [OneTimeSetUp]
        public void init()
        {
            mockPlayerMapper = new Mock<IPlayerMapper>();
            mockPlayerMapper.Setup(s => s.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
        }
        
        [Test]
        [TestCase("King")]
        [TestCase("Kohli")]
        public void TestPlayer(string name)
        {  
            Player p = Player.RegisterNewPlayer(name, mockPlayerMapper.Object);
            Assert.That(name, Is.EqualTo(p.Name));
            Assert.That(23, Is.EqualTo(p.Age));
            Assert.That("India", Is.EqualTo(p.Country));
            Assert.That(30, Is.EqualTo(p.NoOfMatches));

        }
    }
}
