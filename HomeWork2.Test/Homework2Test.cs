using NUnit.Framework;
using HomeWork2;
using System;
using Microsoft.VisualBasic.CompilerServices;

namespace HomeWork2.Test
{
    public class Homework2Test

    {

        Homework2 hw2;
        double[,] array1;
        double[,] array2;
        double[,] array3;

        [OneTimeSetUp]
        public void OneTimSetUp()
        {

        }

        [SetUp]
        public void Setup()
        {
            hw2 = new Homework2();
            array1 = new double[,] { { 0, 1 }, { 1, 0 } };
            array2 = new double[,] { { 0, 1, 1 }, { 1, 0, 2 }, { 1, 0, 2 } };
            array3 = new double[,] { { 1, 1 }, { 1, 1 } };
        }
        
        
        [TestCase(1, 2, 1, 0)]
        [TestCase(80, 8, 1, -256)]
        [TestCase(0, -95, 1, 9025)]
        [TestCase(-9, 0, 1, 36)]
        [TestCase(2, 8, 0, 64)]
        public void GetDiscriminantTest(int a, int b, int c, int expected)
        {
 
            double actual = hw2.GetDiscriminant(a, b, c);
            
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 12, 0, new double[] {-6})]
        [TestCase(1, -2, 16, new double[] {3, -1})]
        [TestCase(1, -8, 16, new double[] {6, 2})]
        [TestCase(5, 3, -131, new double[] { })]
        [TestCase(1, -6, 0, new double[] { 3})]
        
        public void GetRootsTest(double a, double b, double d, double[] expected)
        {
            double[] actual = hw2.GetRoots(a, b, d);
            if (expected.Length != actual.Length)
            {
                Assert.Warn($"{expected.Length}, {actual.Length}");
                Assert.Fail();

            }
            switch (expected.Length)
            {
                case 1:
                    if (Math.Round(actual[0], 2) != Math.Round(expected[0], 2))
                    {
                        Assert.Warn($"Значения {expected[0]}, {actual[0]}"); 
                        Assert.Fail();
                    }
                    break;
                case 2:
                    if (Math.Round(actual[0], 2) != Math.Round(expected[0], 2) || Math.Round(actual[1], 2) != Math.Round(expected[1], 2))
                    {
                        Assert.Warn($"Значения {expected}, {actual}");
                        Assert.Fail();
                    }
                    break;
                
                    

            }


           
        }


        [TestCase(10, "Ten")]
        [TestCase(12, "Twelve")]
        [TestCase(222, "")]
        [TestCase(0, "")]
        [TestCase(-17, "")]
        [TestCase(99, "Ninety nine")]
        public void PrintTwoDigitNumberTest(int a, string expected)
        {
            string actual = hw2.PrintTwoDigitNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 8, 0, false)]
        [TestCase(2, 1, 9, true)]
        [TestCase(5, 3, 0, false)]
        [TestCase(0, 1, 8, true)]
        [TestCase(2, 0, 0, false)]
        
        public void PointInCircleTest(int x, int y, int r, bool expected)
        {
            
            bool actual = hw2.PointInCircle(x, y, r);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 1, 5)]
        [TestCase(8, 0, 1)]
        [TestCase(1, 99, 1)]
        [TestCase(-2, 5, -32)]
        [TestCase(0, 8, 0)]
        public void GetRaiseToPowerTest(int a, int b, int expected)
        {
            int actual = hw2.GetRaiseToPower(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(500, new int[] {  500, 1000})]
        [TestCase(333, new int[] { 333, 666, 999})]
        [TestCase(0, new int[] { })]
        [TestCase(-200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(int.MaxValue, new int[] { })]
        public void GetDivisorsNumberTest(int divider, int[] expected)
        {
            int[] actual = hw2.DoTaskLogic(divider);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(8, 36)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        [TestCase(12, 78)]
        [TestCase(1, 1)]
        public void SumOneToNTest(int n, int expected)
        {
            int actual = hw2.SumOneToN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 21)]
        [TestCase(0, 0)]
        [TestCase(-8, 28)]
        [TestCase(10, 55)]
        [TestCase(1, 1)]
        public void GetEquationTest(int n, int expected)
        {
            int actual = hw2.GetEquation(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-7, 0)]
        [TestCase(46, 1836311903)]
        [TestCase(47, 0)]
        public void GetFibonacciNumberTest(int n, int expected)
        {
            int actual = hw2.GetFibonacciNumber(n);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(8, 4)]
        [TestCase(0, 2147483647)]
        [TestCase(-5, 5)]
        [TestCase(12, 6)]
        [TestCase(1084, 542)]
        public void GetGreatestDivisorTest(int a, int expected)
        {
            int actual = hw2.GetGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 4, 3, 2, 1 },  0)]
        [TestCase(new int[] {}, 0)]
        [TestCase(new int[] {-100, 50, 30, 95}, 3)]
        [TestCase(new int[] { 0, 55, 30, 2, 17 }, 1)]
        [TestCase(new int[] { 100}, 0)]

        public void FindMaxIndexTest(int[] array, int expected)
        {
            int actual = hw2.FindMaxIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 100, 51, 84, 65 , 5 }, 116)]
        [TestCase(new int[] {}, 0)]
        [TestCase(new int[] {-100, -50, 80, 6}, -44)]
        [TestCase(new int[] {1, -100, 5, 100 }, 0)]
        [TestCase(new int[] {0, 0, 0, 0}, 0)]
        public void SumArrayOddIndexTest(int[] array, int expected)
        {
            int actual = hw2.SumArrayOddIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { -100, -50, -150 }, -100)]
        [TestCase(new int[] { -100, 50, 50 }, 0)]
        
        public void CalcAverageTest(int[] array, int expected)
        {
            //act
            int actual = hw2.CalcAverage(array);

            //assert
            Assert.AreEqual(expected, actual);


        }


        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { }, 5, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 3, 4, 7 }, 4, new int[]{3})]
        [TestCase(new int[] {-100, 50, 50} , 0, new int[] {-100})] 
        [TestCase(new int[] { -100, 50, 50 } , -200, new int[] { })]       
        
        public void GetElementsThanAverageTest(int[] array, int average, int[] expected)
        {
            //act
            int[] actual = hw2.GetElementsThanAverage(array, average);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { -8, 0, 5, 93}, new int[] {93, 5, 0, -8})]
        [TestCase(new int[] {100}, new int[] {100})]
        [TestCase(new int[] {55, 33}, new int[] {33, 55})]
        [TestCase(new int[] {0, 0, 1, 0, 0}, new int[] { 0, 0, 1, 0, 0 })]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            int[] actual = hw2.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        }





    }
}