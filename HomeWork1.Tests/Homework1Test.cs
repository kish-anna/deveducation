using NUnit.Framework;
using System;

namespace HomeWork1.Tests
{
    public class Homework1Test
    {
        Homework1 hw1;

        [SetUp]
        public void Setup()
        {
            hw1 = new Homework1();
        }

        [TestCase(20, 30)]
        [TestCase(0, 30)]
        [TestCase(20, 0)]
        [TestCase(-20, 30)]
        [TestCase(20, -30)]
        public void SwapTest(int a, int b)
        {
            (int first, int second) = hw1.Swap(a, b);
            if (first != b || second != a)
            {
                Assert.Fail();
            }
        }

        [TestCase(20, 30, 36.06)]
        [TestCase(3, 4, 5)]
        [TestCase(100, 5, 100.12)]
        [TestCase(-20, 30, 0)]
        [TestCase(20, 0, 0)]
        public void GetHypotenuseTest(double a, double b, double expected)
        {
            double actual = Math.Round(hw1.GetHypotenuse(a, b), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, 30, 40, 0.5)]
        [TestCase(3, 4, 0, -1.33)]
        [TestCase(1, 2.5, 3, 0.5)]
        [TestCase(-20, 30, 15, 0.75)]
        [TestCase(20, 0, 0, 0)]
        public void CalculationEquationTest(double a, double b, double c, double expected)
        {
            double actual = Math.Round(hw1.CalculationEquation(a, b, c), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 30, -30)]
        [TestCase(3, 4, -1)]
        [TestCase(5, 100, -95)]
        [TestCase(-20, 30, -50)]
        [TestCase(20, 0, 20)]
        public void ConditionComparisonTest(int a, int b, int expected)
        {
            int actual = hw1.ConditionComparison(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 5, 5, 0)]
        [TestCase(3, 4, 0, 3)]
        [TestCase(5, 100, 0, 5)]
        [TestCase(-20, 30, 0, -20)]
        [TestCase(20, 0, 0, 0)]
        public void GetDivisionWithRemainderTest(int a, int b, int expected1, int expected2)
        {
            (int result1, int result2) = hw1.GetDivisionWithRemainder(a, b);

            if (result1 != expected1 || result2 != expected2)
            {
                Assert.Fail();
            }
        }

        [TestCase(0, 0, 0)]
        [TestCase(10, 6, 1)]
        [TestCase(-5, 77, 2)]
        [TestCase(-18, -1, 3)]
        [TestCase(5, -66, 4)]
        [TestCase(0, 98, 12)]
        [TestCase(-54, 0, 23)]
        [TestCase(0, -10, 34)]
        public void FindQuarterTest(int x, int y, int expected)
        {
            int actual = hw1.FindQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}