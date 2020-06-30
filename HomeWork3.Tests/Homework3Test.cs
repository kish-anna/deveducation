using NUnit.Framework;
using HomeWork3;

namespace HomeWork3.Tests
{
    public class Homework3Test
    {
        Homework3 hw3;
        int[,] array1;
        int[,] array2;
        int[,] array3;


        [SetUp]

        

        public void Setup()
        {
            hw3 = new Homework3();
            array1 = new int[,] { { 0, 1, 5 }, { 4, 7, 6 }, { 2, 5, 2 } };
            array2 = new int[,] { { 0, 0, 0 }, { 1, 1, 1}, { 2, 2, 2 } };
            array3 = new int[,] { { 0, 1, 5 , 5}, { 4, 7, 6 , 0}, { 2, 5, 2 , 55}, { 4, 5, 2, 36 } };


        }

        [TestCase(54, 5965, "Ура! мы наконец-то нашли совпадение!")]
        [TestCase(444, 756, "Совпадений нет!")]
        [TestCase(10, 195, "Ура! мы наконец-то нашли совпадение!")]
        [TestCase(-3, 100, "Совпадений нет!")]
        [TestCase(33, 3596, "Ура! мы наконец-то нашли совпадение!")]

        public void CheckSameNumbersTest(int h, int g, string expected)
        {
            string actual = hw3.CheckSameNumbers(g, h);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(965, 569)]
        [TestCase(100, 001)]
        [TestCase(0, 0)]
        [TestCase(557, 755)]
        public void ExpandNumbersTest(int a, int expected)
        {

            double actual = hw3.ExpandNumbers(a);

            Assert.AreEqual(expected, actual);

        }
        [TestCase("+", 5, 1, 6)]
        [TestCase("-", 17, 7, 10)]
        [TestCase("*", 0, 1, 0)]
        [TestCase("5", 5, 87, 5)]
        [TestCase("+", 99, 1, 100)]
        public void DoCalculationsTest(string o, int a, int b, int expected)
        {
            double actual = hw3.DoCalculations(o, a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { -8, 0, 5, 93 }, new int[] { 5, 93, -8, 0 })]
        [TestCase(new int[] { 100 }, new int[] { 100 })]
        [TestCase(new int[] { 55, 33 }, new int[] { 33, 55 })]
        [TestCase(new int[] { 1001, 25, 1, -555, 0, 8 }, new int[] { -555, 0, 8, 1001, 25, 1 })]
        public void SwapArrayTest(int[] array, int[] expected)
        {
            int[] actual = hw3.SwapArray(array);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 3, 5)]
        [TestCase(new int[] { 0, 200, -100, 4 }, 0, 1, 0)]
        [TestCase(new int[] { 5 }, 0, 0, 0)]
        [TestCase(new int[] { -30, 8, 30 }, 0, 2, 8)]
        [TestCase(new int[] { 8, 8, 8 }, 0, 0, 0)]
        public void SumArrayTest(int[] array, int min, int max, int expected)
        {
            int actual = hw3.SumArray(array, min, max);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 4, 3, 2, 1 }, 0, 4)]
        [TestCase(new int[] { }, 0, 0)]
        [TestCase(new int[] { -100, 50, 30, 95 }, 3, 0)]
        [TestCase(new int[] { 0, 55, 30, 2, 17 }, 1, 0)]
        [TestCase(new int[] { 100 }, 0, 0)]

        public void FindMaxMinTest(int[] array, int expected1, int expected2)
        {
            (int actual1, int actual2) = hw3.FindMaxMin(array);
            if (actual1 != expected1 || actual2 != expected2)
            {
                Assert.Warn($"actual {actual1}, expected1 {expected1 }, actual2 {actual2}, expected2 {expected2}");
                Assert.Fail();
            }

        }

        [TestCase(5, new int[] { 5, 2, 10 }, 1)]
        [TestCase(8, new int[] { -50, 66, 3, 502 }, 0)]
        [TestCase(7, new int[] { }, 0)]
        [TestCase(9, new int[] { 9, 9, 9, 9, 9 }, 5)]
        [TestCase(1, new int[] { 1 }, 1)]
        public void FindNumberTest(int c, int[] array, int expected)
        {
            int actual = hw3.FindNumber(c, array);
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(1, 1, "+", "-", "-\n")]
        [TestCase(2, 2, "*", "-", "--\n--\n")]
        [TestCase(2, 3, "#", "*", "**\n**\n**\n")]
        [TestCase(0, 5, "+", "-", "\n\n\n\n\n")]
        [TestCase(3, 1, "&", "|", "|||\n")]
        [TestCase(4, 4, ":", ",", ",,,,\n,::,\n,::,\n,,,,\n")]

        public void PrintRectangleTest(int a, int b, string symbol, string symbolFrame, string expected)
        {
            string actual = hw3.PrintRectangle(a, b, symbol, symbolFrame);
            Assert.AreEqual(expected, actual);
        }
        [TestCase("+", true)]
        [TestCase("h", false)]
        [TestCase("/", true)]
        [TestCase("++", false)]
        [TestCase("*", true)]
        public void CheckOpirationTest(string o, bool expected)
        {
            bool actual = hw3.CheckOpiration(o);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase("/", 0, true)]
        [TestCase("+", 0, true)]
        [TestCase("/", 5, true)]
        [TestCase("-", 18, true)]
        [TestCase("/", 10, true)]
        public void CheckDivisionByZeroTest(string o, int b, bool expected)
        {
            bool actual = hw3.CheckOpiration(o);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 0, "array1", false)]
        [TestCase(1, 2, "array2", false)]
        [TestCase(1, 1, "array3", true)]
        [TestCase(2, 0, "array1", false)]
        [TestCase(1, 1, "array2", false)]
        public void CompareArrayCellsTest(int i, int j, string arrayName, bool expected)
        {
            int[,] array = new int[,] { };
            switch (arrayName)
            {
                case "array1":
                    array = array1;
                    break;
                case "array2":
                    array = array2;
                    break;
                case "array3":
                    array = array3;
                    break;

            }
            
            
            bool actual = hw3.CompareArrayCells(i, j, array);
            Assert.AreEqual(expected, actual);
        }

        









    }
}