using System;
using NUnit.Framework;
using StructuredProgramming;

namespace StructuredProgrammingTest
{
	[TestFixture]
	public class CommandLineParserTest : CommandLineParser
	{
		[Test]
		public void TestAreEqual()
		{
			Assert.AreEqual("ABC", testString);
		}
	}
}

