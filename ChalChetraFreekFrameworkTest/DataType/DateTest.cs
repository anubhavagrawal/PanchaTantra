using System;
using ChalChetraFreek.DataType;
using NUnit.Framework;

namespace ChalChetraFreekFrameworkTest.DataType
{
    [TestFixture]
    public class DateTest
    {
        [Test]
        public void ShouldConstructTheDateProperly()
        {
            new Date("08/04/2011");
        }

        [Test]
        public void ShouldThroughExceptionForEmptyDate()
        {
            try
            {
                new Date("");
                Assert.Fail("Empty Date Created");
            }
            catch (FormatException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void ShouldThrowExceptionForInvalidDateFormat()
        {
            try
            {
                new Date("abcd04/2011");
                Assert.Fail("Invalid Date Created");
            }
            catch (FormatException) { Assert.Pass(); }
        }

        [Test]
        public void ShouldThrowExceptionForInvalidDate()
        {
            try
            {
                new Date("32/04/2011");
                Assert.Fail("Invalid Date Created");
            }
            catch (FormatException) { Assert.Pass(); }
        }

        [Test]
        public void ShouldSetDayMonthYear()
        {
            var date = new Date("08/04/2011");
            Assert.AreEqual(8, date.WatsYourDay);
            Assert.AreEqual(4, date.WatsYourMonth);
            Assert.AreEqual(2011, date.WatsYourYear);
        }

        [Test]
        public void ShouldSetDateProperly()
        {
            const string dateStr = "08/04/2011";
            var date = new Date(dateStr);
            Assert.AreEqual(dateStr, date.WatsIt);
            Assert.AreEqual(dateStr, date.ToString());

        }

    }
}