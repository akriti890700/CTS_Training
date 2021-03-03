using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;

namespace DirectoryExplorerTests
{
    [TestFixture]
    public class TestClass
    {
        Mock<IDirectoryExplorer> mockDirectoryExplorer;

        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [Test] 
        [TestCase("ABC")]
        public void TestFiles(string path)
        {            
            mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
            string[] files = { _file1, _file2 };
            mockDirectoryExplorer.Setup(p => p.GetFiles(It.IsAny<string>())).Returns(files);

            var result = mockDirectoryExplorer.Object.GetFiles(path);


            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
            Assert.That(result.Any(p=>p.Contains(_file1)));
        }
    }
}
