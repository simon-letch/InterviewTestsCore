using System;
using NUnit.Framework;

namespace InterviewTestsCore
{
    public class CalculatorTest
    {
        [Test]
        [TestCase(2, "1 + 1")]
        [TestCase(1, "100 - 99")]
        [TestCase(50, "50 - 45 + 45")]
        [TestCase(80, "1 + 5 + 100 - 26")]
        [TestCase(2, "1 + 1 + 1 - 1 - 1 + 1")]
        [TestCase(-100, "100 - 200")]
        public void StringCalculator(int expectedResult, string expression)
        {
            Assert.That(Calculate(expression), Is.EqualTo(expectedResult));
        }

        private int Calculate(string expression)
        {
            throw new NotImplementedException();
        }
    }
}