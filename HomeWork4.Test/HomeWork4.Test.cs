using NUnit.Framework;

namespace HomeWork4.Test
{
    public class Homework4Test
    {
        Homework4 hw4;
        [SetUp]
        public void Setup()
        {
            hw4 = new Homework4();
        }

        [TestCase( 50, 40, 10)]
        [TestCase( 0, 0, 0)]
        [TestCase(100, 100, 100)]
        [TestCase(150, 0, 150)]
        [TestCase(-50, 86, 0)]
        public void GetEuclideanAlgorithmTest(int a, int b, int expected)
        {

            int actual = hw4.GetEuclideanAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 2, 1, 3 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] {99, -30, 5}, new int[] { -30, 5, 99})]
        [TestCase(new int[] { 0, 1, 2, 8 }, new int[] { 0, 1, 2, 8 })]
        [TestCase(new int[] { 44, 2, 17, 3 }, new int[] { 2, 3, 17, 44 })]
        [TestCase(new int[] {0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        public void SortTest(int[] array, int[] expected)
        {
            int[] actual = hw4.Sort(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 7, 1, -427)]
        [TestCase(1, 1, 50, 1)]
        [TestCase(20, 9, 1000, 20)]
        [TestCase(30, 3, 0, 30)]
        [TestCase(2000, 6, 5, 1340)]

        public void CountingCaloriesTest(int calories, int make, int howMuch, int expected)
        {
            int actual = hw4.CountingCalories(calories, make, howMuch);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(600, 20)]
        [TestCase(1520, 50)]
        [TestCase(659, 21)]
        [TestCase(30, 1)]
        [TestCase(-952, -31)]

        public void CaloriesToFatTest(int calories, int expected)
        {
            int actual = hw4.CaloriesToFat(calories);
            Assert.AreEqual(expected, actual);
        }
    }
}