using System;
using System.Diagnostics;
using System.Linq;
using HomeWorkLinkedList;
using HomeWorkArrayList;
using HomeWorkDoublyLinkedList;

namespace Benchmark
{
    class Program
    {
        private static int _N = 1;
        private static double[,] _benchmark = new double[25, 9];
        private static int[] _sizes = {100, 100000, 1000000};


        static void Main(string[] args)
        {
            ArrayListAddFirstBenchmark();
            LinkedListAddFirstBenchmark();
            DoublyLinkedListAddFirstBenchmark();
            Console.WriteLine("AddFirst - Pass");
            ArrayListAddFirstArrayBenchmark();
            LinkedListAddFirstArrayBenchmark();
            DoublyLinkedListAddFirstArrayBenchmark();
            Console.WriteLine("AddFirstArray - Pass");
            ArrayListAddLastBenchmark();
            LinkedListAddLastBenchmark();
            DoublyLinkedListAddLastBenchmark();
            Console.WriteLine("AddLast - Pass");
            ArrayListAddLastArrayBenchmark();
            LinkedListAddLastArrayBenchmark();
            DoublyLinkedListAddLastArrayBenchmark();
            Console.WriteLine("AddLastArray - Pass");
            ArrayListAddAtBenchmark();
            LinkedListAddAtBenchmark();
            DoublyLinkedListAddAtBenchmark();
            Console.WriteLine("AddAt - Pass");
            ArrayListAddAtArrayBenchmark();
            LinkedListAddAtArrayBenchmark();
            DoublyLinkedListAddAtArrayBenchmark();
            Console.WriteLine("AddAtArray - Pass");
            ArrayListGetSizeBenchmark();
            LinkedListGetSizeBenchmark();
            DoublyLinkedListGetSizeBenchmark();
            Console.WriteLine("GetSize - Pass");
            ArrayListSetBenchmark();
            LinkedListSetBenchmark();
            DoublyLinkedSetBenchmark();
            Console.WriteLine("Set - Pass");
            ArrayListRemoveFirstBenchmark();
            LinkedListRemoveFirstBenchmark();
            DoublyLinkedRemoveFirstBenchmark();
            Console.WriteLine("RemoveFirst - Pass");
            ArrayListRemoveLastBenchmark();
            LinkedListRemoveLastBenchmark();
            DoublyLinkedRemoveLastBenchmark();
            Console.WriteLine("RemoveLast - Pass");
            ArrayListRemoveAtBenchmark();
            LinkedListRemoveAtBenchmark();
            DoublyLinkedRemoveAtBenchmark();
            Console.WriteLine("RemoveAt - Pass");
            ArrayListRemoveAllBenchmark();
            LinkedListRemoveAllBenchmark();
            DoublyLinkedRemoveAllBenchmark();
            Console.WriteLine("RemoveAll - Pass");
            ArrayListContainsBenchmark();
            LinkedListContainsBenchmark();
            DoublyLinkedContainsBenchmark();
            Console.WriteLine("Contains - Pass");
            ArrayListIndexOfBenchmark();
            LinkedListIndexOfBenchmark();
            DoublyLinkedIndexOfBenchmark();
            Console.WriteLine("IndexOf - Pass");
            ArrayListToArrayBenchmark();
            LinkedListToArrayBenchmark();
            DoublyLinkedToArrayBenchmark();
            Console.WriteLine("ToArray - Pass");
            ArrayListGetFirstBenchmark();
            LinkedListGetFirstBenchmark();
            DoublyLinkedGetFirstBenchmark();
            Console.WriteLine("GetFirst - Pass");
            ArrayListGetLastBenchmark();
            LinkedListGetLastBenchmark();
            DoublyLinkedGetLastBenchmark();
            Console.WriteLine("GetLast - Pass");
            ArrayListGetBenchmark();
            LinkedListGetBenchmark();
            DoublyLinkedGetBenchmark();
            Console.WriteLine("Get - Pass");
            ArrayListReverseBenchmark();
            LinkedListReverseBenchmark();
            DoublyLinkedReverseBenchmark();
            Console.WriteLine("Reverse - Pass");
            ArrayListMaxBenchmark();
            LinkedListMaxBenchmark();
            DoublyLinkedMaxBenchmark();
            Console.WriteLine("Max - Pass");
            ArrayListMinBenchmark();
            LinkedListMinBenchmark();
            DoublyLinkedMinBenchmark();
            Console.WriteLine("Min - Pass");
            ArrayListIndexOfMaxBenchmark();
            LinkedListIndexOfMaxBenchmark();
            DoublyLinkedIndexOfMaxBenchmark();
            Console.WriteLine("IndexOfMax - Pass");
            ArrayListIndexOfMinBenchmark();
            LinkedListIndexOfMinBenchmark();
            DoublyLinkedIndexOfMinBenchmark();
            Console.WriteLine("IndexOfMin - Pass");
            ArrayListSortBenchmark();
            LinkedListSortBenchmark();
            DoublyLinkedSortBenchmark();
            Console.WriteLine("Sort - Pass");
            ArrayListSortDescBenchmark();
            LinkedListSortDescBenchmark();
            DoublyLinkedSortDescBenchmark();
            Console.WriteLine("SortDesc - Pass");


            for (int i = 0; i < _benchmark.GetLength(0); i++)
            {
                for (int j = 0; j < _benchmark.GetLength(1); j++)
                {
                    Console.Write("{0}\t", _benchmark[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void ArrayListAddFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddFirst(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[0, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddFirst(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[0, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddFirst(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[0, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListAddFirstArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddFirst(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[1, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddFirstArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddFirst(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[1, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddFirstArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddFirst(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[1, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListAddLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddLast(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[2, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddLast(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[2, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddLast(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[2, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListAddLastArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddLast(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[3, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddLastArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddLast(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[3, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddLastArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddLast(a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[3, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListAddAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddAt(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[4, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddAt(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[4, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddAt(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[4, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListAddAtArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.AddAt(a, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[5, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListAddAtArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.AddAt(1, a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[5, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListAddAtArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.AddAt(1, a);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[5, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListGetSizeBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.GetSize();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[6, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListGetSizeBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.GetSize();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[6, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedListGetSizeBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.GetSize();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[6, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListSetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Set(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[7, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListSetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Set(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[7, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedSetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Set(10, 1);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[7, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListRemoveFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.RemoveFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[8, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListRemoveFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.RemoveFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[8, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedRemoveFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.RemoveFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[8, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListRemoveLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.RemoveLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[9, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListRemoveLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.RemoveLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[9, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedRemoveLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.RemoveLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[9, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListRemoveAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.RemoveAt(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[10, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListRemoveAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.RemoveAt(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[10, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedRemoveAtBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.RemoveAt(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[10, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListRemoveAllBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.RemoveAll(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[11, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListRemoveAllBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.RemoveAll(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[11, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedRemoveAllBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.RemoveAll(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[11, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListContainsBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Contains(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[12, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListContainsBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Contains(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[12, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedContainsBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Contains(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[12, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListIndexOfBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.IndexOf(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[13, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListIndexOfBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.IndexOf(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[13, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedIndexOfBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.IndexOf(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[13, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListToArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.ToArray();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[14, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListToArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.ToArray();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[14, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedToArrayBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.ToArray();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[14, i + 6] = r / _N; //потом i+3, i+6
            }
        }


        public static void ArrayListGetFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.GetFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[15, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListGetFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.GetFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[15, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedGetFirstBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.GetFirst();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[15, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListGetLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.GetLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[16, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListGetLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.GetLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[16, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedGetLastBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.GetLast();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[16, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListGetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Get(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[17, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListGetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Get(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[17, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedGetBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Get(10);
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[17, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListReverseBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Reverse();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[18, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListReverseBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Reverse();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[18, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedReverseBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Reverse();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[18, i + 6] = r / _N; //потом i+3, i+6
            }
        }


        public static void ArrayListMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Max();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[19, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Max();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[19, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Max();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[19, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Min();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[20, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Min();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[20, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Min();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[20, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListIndexOfMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.IndexOfMax();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[21, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListIndexOfMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.IndexOfMax();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[21, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedIndexOfMaxBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.IndexOfMax();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[21, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListIndexOfMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.IndexOfMin();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[22, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListIndexOfMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.IndexOfMin();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[22, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedIndexOfMinBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.IndexOfMin();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[22, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        public static void ArrayListSortBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                // Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    // Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.Sort();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[23, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListSortBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.Sort();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[23, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedSortBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.Sort();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[23, i + 6] = r / _N; //потом i+3, i+6
            }
        }


        public static void ArrayListSortDescBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    ArrayList l = new ArrayList(a);

                    sw.Start();
                    l.SortDesc();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[24, i] = r / _N; //потом i+3, i+6
            }
        }

        public static void LinkedListSortDescBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    LinkedList l = new LinkedList(a);

                    sw.Start();
                    l.SortDesc();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[24, i + 3] = r / _N; //потом i+3, i+6
            }
        }

        public static void DoublyLinkedSortDescBenchmark()
        {
            for (int i = 0; i < _sizes.Length; i++)
            {
                //Console.WriteLine($"i ={i}");
                int[] a = GetArray(_sizes[i], -100, 101);
                Stopwatch sw = new Stopwatch();

                double r = 0;

                for (int j = 0; j < _N; j++)
                {
                    //Console.WriteLine($"_N ={j}");
                    DoublyLinkedList l = new DoublyLinkedList(a);

                    sw.Start();
                    l.SortDesc();
                    sw.Stop();

                    r += sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                }

                _benchmark[24, i + 6] = r / _N; //потом i+3, i+6
            }
        }

        static int[] GetArray(int n, int min, int max)
        {
            Random r = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(min, max);
            }

            return a;
        }
    }
}