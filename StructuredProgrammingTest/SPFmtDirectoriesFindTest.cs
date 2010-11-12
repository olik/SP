using System;
using NUnit.Framework;
using StructuredProgramming;

namespace StructuredProgrammingTest
{
	[TestFixture]
	public class SPFmtDirectoriesFindTest : SPFmtDirectoriesFind
	{
		[Test]
		public void CurrentDirectoryTest()
		{
			Assert.AreEqual("C:\\Users\\olik\\Documents\\Projects\\StructuredProgramming", CurrentDirectory);
		}
		[Test]
		public void SPFmtFilesTests()
		{
			Assert.AreNotEqual(null, SPFmtFiles);
			Assert.AreEqual(1, SPFmtFiles.Length);
			Assert.AreEqual("C:\\Users\\olik\\Documents\\Projects\\StructuredProgramming\\test.spfmt", SPFmtFiles[0]);
		}
	}
}

