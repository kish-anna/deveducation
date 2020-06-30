using NUnit.Framework;

namespace HomeWorkDoublyLinkedList.Test
{
    public class DoublyLinkedListTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(new int[] { 1, 2, 3 }, 5, new int[] { 5, 1, 2, 3 })]
        [TestCase(new int[] {}, 5, new int[] { 5 })]
        [TestCase(new int[] { 0 }, 5, new int[] { 5, 0 })]
        [TestCase(new int[] { 101, 101, 101 }, 101, new int[] { 101, 101, 101, 101 })]
        [TestCase(new int[] { 5 }, 0, new int[] { 0, 5})]
        public void AddFirstTest(int[] array, int value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.AddFirst(value);
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 5 }, new int[] { 5 }, new int[] { 5, 5 })]
        [TestCase(new int[] { 3, 4, 5 }, new int[] { }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0 }, new int[] { 0, 0, 0, 0, 0, 0 })]
        public void AddFirstArrayTest(int[] array, int[] value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.AddFirst(value);
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 5, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { }, 5, new int[] { 5 })]
        [TestCase(new int[] { 1 }, 5, new int[] { 1, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3, 0 })]
        [TestCase(new int[] { 101, 101 }, 101, new int[] { 101, 101, 101 })]
        public void AddLastTest(int[] array, int value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.AddLast(value);
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 3, 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 3, 4, 5 }, new int[] { }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 101, 101, 101 }, new int[] { 101, 101 }, new int[] { 101, 101, 101, 101, 101 })]
        public void AddLastArrayTest(int[] array, int[] value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.AddLast(value);
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 0, 5, new int[] { 5, 1, 2, 3, })]
        [TestCase(new int[] { }, 0, 1, new int[] { 1 })]
        [TestCase(new int[] { 1 }, 0, 5, new int[] { 5, 1 })]
        [TestCase(new int[] { 0, 1, 2 }, 15, 5, new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 101, 101, 101 }, 2, 0, new int[] { 101, 101, 0, 101 })]
        public void AddAtTest(int[] array, int index, int value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (index < 0 || index >= array.Length)
            {
                Assert.Throws<System.Exception>(() => a.AddAt(index, value));
            }
            else
            {
                a.AddAt(index, value);
                int[] actual = a.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { }, 0, new int[] { }, new int[] { })]
        [TestCase(new int[] { 3, 4, 5 }, 2, new int[] { 1, 2, 3 }, new int[] { 3, 4, 1, 2, 3, 5 })]
        [TestCase(new int[] { }, 2, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 1 })]
        [TestCase(new int[] { 101, 101, 101 }, 0, new int[] { 101, 101 }, new int[] { 101, 101, 101, 101, 101 })]
        public void AddAtArrayTest(int[] array, int index, int[] value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (index < 0 || index >= array.Length)
            {
                Assert.Throws<System.Exception>(() => a.AddAt(index, value));
            }
            else
            {
                a.AddAt(index, value);
                int[] actual = a.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }


        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 8)]
        [TestCase(new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 5)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetSizeTest(int[] value, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(value);
            int actual = a.GetSize();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, 0, 555, new int[] { 555, 4, 5 })]
        [TestCase(new int[] { 3, 4, 5 }, 2, 1, new int[] { 3, 4, 1 })]
        [TestCase(new int[] { }, 0, 555, new int[] { 555 })]
        [TestCase(new int[] { 3, 4, 5 }, 555, 555, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 3, 4, 5 }, 0, 555, new int[] { 555, 4, 5 })]
        public void SetTest(int[] array, int index, int value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (index < 0 || index >= array.Length)
            {
                Assert.Throws<System.Exception>(() => a.Set(index, value));
            }
            else
            {
                a.Set(index, value);
                int[] actual = a.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 3, 4, 5 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(new int[] { 101, 101, 101 }, new int[] { 101, 101 })]
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.RemoveFirst();
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, new int[] { 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 0 }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 })]
        [TestCase(new int[] { 101, 101, 101 }, new int[] { 101, 101 })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.RemoveLast();
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, 1, new int[] { 3, 5 })]
        [TestCase(new int[] { 3, 4, 5 }, 0, new int[] { 4, 5 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, new int[] { 0, 1, 2, 3, 4, 6, 7, 8, 9 })]
        [TestCase(new int[] { 3, 4, 5 }, 5555, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 3 }, 0, new int[] { })]
        public void RemoveAtTest(int[] array, int index, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (index < 0 || index >= array.Length)
            {
                Assert.Throws<System.Exception>(() => a.RemoveAt(index));
            }
            else
            {
                a.RemoveAt(index);
                int[] actual = a.ToArray();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 9, new int[] { 1, 2, 3, 4, 5, 1 })]
        [TestCase(new int[] { 3, 4, 5 }, 0, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 55 }, 55, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1 }, 2, new int[] { 1 })]
        public void RemoveAllTest(int[] array, int value, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.RemoveAll(value);
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 4, 5 }, 1, false)]
        [TestCase(new int[] { 3, 4, 5 }, 5, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 9, true)]
        [TestCase(new int[] { 0 }, 100, false)]
        [TestCase(new int[] { }, 9, false)]
        public void ContainsTest(int[] array, int value, bool expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);

            bool actual = a.Contains(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 9, 4)]
        [TestCase(new int[] { 3, 4, 5 }, 0, -1)]
        [TestCase(new int[] { 55 }, 55, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, 1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 2)]
        public void IndexOfTest(int[] array, int value, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            int actual = a.IndexOf(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, new int[] { 1, 2, 3, 4, 9, 9, 5, 1 })]
        [TestCase(new int[] { 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 5, 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5, 5 })]
        public void ToArrayTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);

            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 1)]
        [TestCase(new int[] { 3, 4, 5 }, 3)]
        [TestCase(new int[] { 55 }, 55)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void GetFirstTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.GetFirst());
            }
            else
            {
                int actual = a.GetFirst();
                Assert.AreEqual(expected, actual);

            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 1)]
        [TestCase(new int[] { 3, 4, 5 }, 5)]
        [TestCase(new int[] { 55 }, 55)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void GetLastTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.GetLast());
            }
            else
            {
                int actual = a.GetLast();
                Assert.AreEqual(expected, actual);

            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 5, 9)]
        [TestCase(new int[] { 3, 4, 5 }, 0, 3)]
        [TestCase(new int[] { 55 }, 0, 55)]
        [TestCase(new int[] { }, 0, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 4)]
        public void GetTest(int[] array, int index, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.Get(index));
            }
            else
            {
                int actual = a.Get(index);
                Assert.AreEqual(expected, actual);

            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, new int[] { 1, 5, 9, 9, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 4, 5 }, new int[] { 5, 4, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void ReverseTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.Reverse();
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 9)]
        [TestCase(new int[] { 3, 4, 5 }, 5)]
        [TestCase(new int[] { 55 }, 55)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void MaxTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.Max());
            }
            else
            {
                int actual = a.Max();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 1)]
        [TestCase(new int[] { 3, 4, 5 }, 3)]
        [TestCase(new int[] { 55 }, 55)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void MinTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.Min());
            }
            else
            {
                int actual = a.Min();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 4)]
        [TestCase(new int[] { 3, 4, 5 }, 2)]
        [TestCase(new int[] { 55 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(new int[] { }, 0)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.IndexOfMax());
            }
            else
            {
                int actual = a.IndexOfMax();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, 0)]
        [TestCase(new int[] { 5, 4, 3 }, 2)]
        [TestCase(new int[] { 55 }, 0)]
        [TestCase(new int[] { 56, 846, 55, 1000 }, 2)]
        [TestCase(new int[] { }, 0)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            if (array.Length == 0)
            {
                Assert.Throws<System.Exception>(() => a.IndexOfMin());
            }
            else
            {
                int actual = a.IndexOfMin();
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, new int[] { 1, 1, 2, 3, 4, 5, 9, 9 })]
        [TestCase(new int[] { 3, 5, 4 }, new int[] { 3, 4, 5 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.Sort();
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 9, 9, 5, 1 }, new int[] { 9, 9, 5, 4, 3, 2, 1, 1 })]
        [TestCase(new int[] { 3, 4, 5 }, new int[] { 5, 4, 3 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescTest(int[] array, int[] expected)
        {
            DoublyLinkedList a = new DoublyLinkedList(array);
            a.SortDesc();
            int[] actual = a.ToArray();
            Assert.AreEqual(expected, actual);
        }
    }
}