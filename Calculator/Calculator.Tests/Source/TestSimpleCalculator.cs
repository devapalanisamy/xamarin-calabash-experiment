using System;
using NUnit.Framework;
using Calculator.Core;

namespace Calculator.Tests
{
	[TestFixture()]
	public class TestSimpleCalculator
	{
		private SimpleCalculator simpleCalculator;

		public TestSimpleCalculator ()
		{
		}

		[Test()]
		public void TestAddMethod()
		{
			Assert.AreEqual (15, simpleCalculator.Add (10, 5));
		}

		[SetUp]
		public void SetUpSimpleCalculator()
		{
			simpleCalculator = new SimpleCalculator ();
		}
	}
}

