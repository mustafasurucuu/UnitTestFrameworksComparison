using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace Assertions.NUnitSpecializedAsserts
{
    [TestFixture]
    public class SpecializedAsserts_NUnit
    {
        [Test]
        public void FileChecks()
        {
            var realFilePath = Assembly.GetExecutingAssembly().Location;
            var realFileInfo = new FileInfo(realFilePath);

            var realDirectoryPath = Path.GetDirectoryName(realFilePath);
            var realDirectoryInfo = new DirectoryInfo(realDirectoryPath);

            var nonexistantFilePath = "E:/ fake.folder / this.is.fake";
            var nonexistantFileInfo = new FileInfo(nonexistantFilePath);

            var nonexistantDirectoryPath = Path.GetDirectoryName(nonexistantFilePath);
            var nonexistantDirectoryInfo = new DirectoryInfo(nonexistantDirectoryPath);

            Assert.That(realFilePath, Does.Exist);
            Assert.That(realFileInfo, Does.Exist);

            Assert.That(nonexistantFilePath, Does.Not.Exist);
            Assert.That(nonexistantFileInfo, Does.Not.Exist);

            Assert.That(realDirectoryPath, Does.Exist);
            Assert.That(realDirectoryInfo, Does.Exist);

            Assert.That(nonexistantDirectoryPath, Does.Not.Exist);
            Assert.That(nonexistantDirectoryInfo, Does.Not.Exist);

            Assert.That(realDirectoryInfo, Is.Not.Empty);

            Assert.That("/folder1/./junk/../folder2", Is.SamePath("/folder1/folder2"));
            Assert.That("/folder1/./junk/../folder2/..", Is.Not.SamePath("/folder1/folder2"));

            Assert.That("/folder1/./junk/../folder2", Is.SamePath("/FOLDER1/folder2").IgnoreCase);
            Assert.That("/folder1/./junk/../folder2", Is.Not.SamePath("/FOLDER1/folder2").RespectCase);


            Assert.That("/folder1/./junk/../folder2/./foo", Is.SamePathOrUnder("/folder1/folder2"));
            Assert.That("/folder1/./junk/../folder2/./foo", Is.SubPathOf("/folder1"));
        }
    }
}
