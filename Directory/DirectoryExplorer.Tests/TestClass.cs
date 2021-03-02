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
        public void TestFiles()
        {            
            mockDirectoryExplorer = new Mock<IDirectoryExplorer>();
            List<string> files = new List<string> { _file1, _file2 };
            mockDirectoryExplorer.Setup(p => p.GetFiles("C:/TestFiles")).Returns(files);

            DirectoryExplorer directoryExplorer = new DirectoryExplorer();
            var result = directoryExplorer.GetFiles("C:/TestFiles");


            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(files.Count));
            Assert.That(result.Any(p=>p.Contains("file")));
        }
    }
}
