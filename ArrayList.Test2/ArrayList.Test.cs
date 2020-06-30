using NUnit.Framework;
using HomeWorkArrayList;

namespace HomeworkArrayList.Test
{
    public class ArrayListTest
    {
        int[] _initArray;

        [SetUp]
        public void Setup()
        {
            _initArray = new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1};
        }

        [Test]
        [TestCase(30, new[] {30, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(15, new[] {15, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(0, new[] {0, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(-40, new[] {-40, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(123456, new[] {123456, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        public void AddFirstTest(int value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddFirst(value);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {1, 2}, new[] {1, 2, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(new[] {1, 2, 3}, new[] {1, 2, 3, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(new[] {0, 0, 0}, new[] {0, 0, 0, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(new[] {-1, -2, -3}, new[] {-1, -2, -3, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(new int[] { }, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        public void AddFirstArrTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddFirst(value);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(1, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 1})]
        [TestCase(0, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 0})]
        [TestCase(-15, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, -15})]
        [TestCase(12, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 12})]
        [TestCase(59874, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 59874})]
        public void AddLastTest(int value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddLast(value);
            Assert.AreEqual(expected, a.ToArray());
        }


        [TestCase(new int[] { }, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(new[] {1, 2}, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 1, 2})]
        [TestCase(new[] {0, 0}, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 0, 0})]
        [TestCase(new[] {-12, -5}, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, -12, -5})]
        [TestCase(new[] {9, 8, 7, 6, 5, 4, 3, 2, 1},
            new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1})]
        public void AddLastArrArrTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddLast(value);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(1, 59874, new[] {1, 59874, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(0, 59874, new[] {59874, 1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(-1, 59874, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(4, 59874, new[] {1, 2, 3, 6, 59874, 9, 13, 56, -1, 0, 1})]
        [TestCase(15, 59874, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        public void AddAtTest(int index, int value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddAt(value, index);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(-1, new[] {1, 2, 4}, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(4, new[] {1, 2, 4}, new[] {1, 2, 3, 6, 1, 2, 4, 9, 13, 56, -1, 0, 1})]
        [TestCase(7, new[] {1, 2, 4}, new[] {1, 2, 3, 6, 9, 13, 56, 1, 2, 4, -1, 0, 1})]
        [TestCase(1, new[] {1, 2, 4}, new[] {1, 1, 2, 4, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(2, new int[] { }, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        public void AddAtArrTest(int index, int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.AddAt(value, index);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {1, 2, 3}, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new[] {1}, 1)]
        public void GetSizeTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.GetSize());
        }

        [TestCase(2, 1, new[] {1, 2, 1, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(-1, 1, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(0, 1, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(5, 92, new[] {1, 2, 3, 6, 9, 92, 56, -1, 0, 1})]
        [TestCase(15, 5, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        public void SetTest(int index, int value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.Set(index, value);
            Assert.AreEqual(expected, a.ToArray());
        }


        [TestCase(new[] {1, 2, 3, 4, 5}, new[] {2, 3, 4, 5})]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new[] {1}, new int[] { })]
        public void RemoveFirstTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            a.RemoveFirst();
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {1, 2, 3, 4, 5}, new[] {1, 2, 3, 4})]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new[] {1}, new int[] { })]
        public void RemoveLastTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            a.RemoveLast();
            Assert.AreEqual(expected, a.ToArray());
        }


        [TestCase(0, new[] {2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(-1, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(20, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(2, new[] {1, 2, 6, 9, 13, 56, -1, 0, 1})]
        public void RemoveAtTest(int index, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.RemoveAt(index);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(30, new[] {1, 2, 3, 6, 9, 13, 56, -1, 0, 1})]
        [TestCase(0, new[] {1, 2, 3, 6, 9, 13, 56, -1, 1})]
        [TestCase(1, new[] {2, 3, 6, 9, 13, 56, -1, 0})]
        [TestCase(56, new[] {1, 2, 3, 6, 9, 13, -1, 0, 1})]
        public void RemoveAllTest(int value, int[] expected)
        {
            ArrayList a = new ArrayList(_initArray);
            a.RemoveAll(value);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(56, true)]
        [TestCase(23, false)]
        public void ContainsTest(int value, bool expected)
        {
            ArrayList a = new ArrayList(_initArray);
            Assert.AreEqual(expected, a.Contains(value));
        }


        [TestCase(56, 6)]
        [TestCase(23, -1)]
        public void IndexOfTest(int value, int expected)
        {
            ArrayList a = new ArrayList(_initArray);
            Assert.AreEqual(expected, a.IndexOf(value));
        }


        [TestCase(new[] {1, 2, 3}, new[] {1, 2, 3})]
        [TestCase(new int[] { }, new int[] { })]
        public void ToArrayTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {1, 2, 3}, 1)]
        [TestCase(new int[] { }, 0)]
        public void GetFirstTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.GetFirst());
        }

        [TestCase(new[] {1, 2, 3}, 3)]
        [TestCase(new int[] { }, 0)]
        public void GetLastTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.GetLast());
        }

        [TestCase(0, 1)]
        [TestCase(-1, 0)]
        [TestCase(1, 2)]
        [TestCase(15, 0)]
        public void GetTest(int index, int expected)
        {
            ArrayList a = new ArrayList(_initArray);
            Assert.AreEqual(expected, a.Get(index));
        }


        [TestCase(new[] {1, 2, 3}, new[] {3, 2, 1})]
        [TestCase(new[] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            a.Reverse();
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {1, 2, 3}, 3)]
        [TestCase(new int[] { }, 0)]
        public void MaxTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.Max());
        }

        [TestCase(new[] {1, 2, 3}, 1)]
        [TestCase(new int[] { }, 0)]
        public void MinTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.Min());
        }

        [TestCase(new[] {1, 2, 3}, 2)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMaxTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.IndexOfMax());
        }

        [TestCase(new[] {1, 2, 3}, 0)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMinTest(int[] value, int expected)
        {
            ArrayList a = new ArrayList(value);
            Assert.AreEqual(expected, a.IndexOfMin());
        }

        [TestCase(new[] {3, 2, 1}, new[] {1, 2, 3})]
        [TestCase(new[] {3, 2, 1, 3, 5, 7, 1}, new[] {1, 1, 2, 3, 3, 5, 7})]
        [TestCase(new int[] { }, new int[] { })]
        public void SortTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            a.Sort();
            Assert.AreEqual(expected, a.ToArray());
        }

        [TestCase(new[] {3, 2, 1}, new[] {3, 2, 1})]
        [TestCase(new[] {3, 2, 1, 3, 5, 7, 1}, new[] {7, 5, 3, 3, 2, 1, 1})]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescTest(int[] value, int[] expected)
        {
            ArrayList a = new ArrayList(value);
            a.SortDesc();
            Assert.AreEqual(expected, a.ToArray());
        }
    }
}