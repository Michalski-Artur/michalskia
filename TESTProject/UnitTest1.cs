using NUnit.Framework;
using System;
using TDD;

namespace TESTProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyStringTest()
        {
            StringCalculator sc = new StringCalculator();
            Assert.AreEqual(0, sc.Add(""));
        }
        [Test]
        public void SingleNumberTest()
        {
            StringCalculator sc = new StringCalculator();            
            string value = "1";
            int expectedResult = 1;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void TwoNumbersCommaDelimited()
        {
            StringCalculator sc = new StringCalculator();
            string value = "1,3";
            int expectedResult = 4;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void TwoNumbersNewLineDelimitedTest()
        {
            StringCalculator sc = new StringCalculator();
            string value = "1\n5";
            int expectedResult = 6;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void ThreeNumbersDelimitedTest()
        {
            StringCalculator sc = new StringCalculator();
            string value = "1,3,5";
            int expectedResult = 9;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void NegativeNumbersTest()
        {
            StringCalculator sc = new StringCalculator();
            string value = "-3";

            Assert.Throws<ArgumentException>(() => sc.Add(value));
        }
        [Test]
        public void NumbersGreaterThan1000Test()
        {
            StringCalculator sc = new StringCalculator();
            string value = "1,3000,5";
            int expectedResult = 6;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void SingleCharDelimiterTest()
        {
            StringCalculator sc = new StringCalculator();
            string value = "//#1#3";
            int expectedResult = 4;

            int result = sc.Add(value);

            Assert.AreEqual(expectedResult, result);
        }
    }
}