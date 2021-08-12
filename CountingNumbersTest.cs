using System;
using NUnit.Framework;

namespace InterviewTestsCore
{
    public class CountingNumbersTest
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(5, "12345")]
        [TestCase(1, "1x")]
        [TestCase(4, "abc1111def")]
        [TestCase(2, "..88'''")]
        [TestCase(0, "")]
        public void CountNumbersTest(int expectedCount, string toCount)
        {
            Assert.That(CountNumbersInString(toCount), Is.EqualTo(expectedCount));
        }

        private int CountNumbersInString(string toCount)
        {
            throw new NotImplementedException();
        }
    }
}