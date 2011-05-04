using System;
using ChalChetraFreek.Entities;
using NUnit.Framework;

namespace ChalChetraFreekFrameworkTest.Entities
{
    [TestFixture]
    public class AwardTest
    {
        [Test]
        public void ShouldCreateAwardProperly()
        {
            new Award(1999, "Film Fare", "Actor");
        }

        [Test]
        public void ShouldThrowExceptionForAwardDateGreaterThenPresentDate()
        {
            try
            {
                new Award(2012, "Film Fare", "Actor");
                Assert.Fail("Award With Invalid Date created");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}