using System;

namespace HomeWorkLinkedList
{
    public class Node
    {
        public int value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.value = value;
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public int Length { get; set; }
        public Node Tail { get; set; }


        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                Length = 0;
                Head = null;
                Tail = null;
                return;
            }

            Head = new Node(values[0]);
            Tail = Head;

            for (int i = 1; i < values.Length; i++)
            {
                Tail.Next = new Node(values[i]);
                Tail = Tail.Next;
            }

            Length = values.Length;
        }


        public void AddFirst(int value)
        {
            Node node = new Node(value);
            if (Head == null)
            {
                Tail = node;
            }

            node.Next = Head;
            Head = node;
            Length++;
            
        }

        public void AddFirst(int[] values)
        {
            for (int i = values.Length - 1; i >= 0; i--)
            {
                AddFirst(values[i]);
            }
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
                Length = 1;
                return;
            }

            Tail.Next = node;
            Tail = node;
            Length++;
            
        }

        public void AddLast(int[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                AddLast(value[i]);
            }
        }


        public void AddAt(int index, int value)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new Exception("Error");
            }

            Node node = new Node(value);

            if (index == 0)
            {
                AddFirst(value);
                return;
            }

            Node before = Head;
            for (int i = 1; i < index; i++)
            {
                before = before.Next;
            }

            node.Next = before.Next;
            before.Next = node;
            Length++;
        }

        public void AddAt(int index, int[] values)
        {
            if (index > Length - 1 || index < 0)
            {
                throw new Exception("Error");
            }

            if (values.Length == 0)
            {
                throw new Exception("Error! Error!");
            }

            if (values.Length == 1)
            {
                AddAt(index, values[0]);
                return;
            }

            if (index == 0)
            {
                AddFirst(values);
                return;
            }

            LinkedList newList = new LinkedList(values);


            Node before = Head;
            for (int i = 1; i < index; i++)
            {
                before = before.Next;
            }

            newList.Tail.Next = before.Next;

            before.Next = newList.Head;
            Length += values.Length;
        }

        public int GetSize()
        {
            return Length;
        }

        public void Set(int index, int value)
        {
            if (index > Length - 1)
            {
                throw new Exception("Error");
            }

            Node current = Head;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }

            current.value = value;
        }

        public void RemoveFirst()
        {
            switch (Length)
            {
                case 0:
                    return;
                case 1:
                    Head = null;
                    Tail = null;
                    Length = 0;
                    break;
                default:
                    Head = Head.Next;
                    Length--;
                    break;
            }
        }

        public void RemoveLast()
        {
            switch (Length)
            {
                case 0:
                    return;
                case 1:
                    Head = null;
                    Tail = null;
                    Length = 0;
                    break;
                default:
                    Node before = Head;
                    for (int i = 1; i < Length - 1; i++)
                    {
                        before = before.Next;
                    }

                    Tail = before;
                    before.Next = null;
                    Length--;
                    break;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > Length - 1)
            {
                throw new Exception("Error");
            }

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            Node before = Head;
            for (int i = 1; i < index; i++)
            {
                before = before.Next;
            }

            before.Next = before.Next.Next;
            Length--;
        }

        public void RemoveAll(int value)
        {
            Node current = Head;
            int i = 0;

            while (current != null)
            {
                if (current.value == value)
                {
                    RemoveAt(i);
                    i--;
                }

                current = current.Next;
                i++;
            }
        }

        public bool Contains(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.value == value)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }


        public int IndexOf(int value)
        {
            Node current = Head;
            int i = 0;
            while (current != null)
            {
                if (current.value == value)
                {
                    return i;
                }

                current = current.Next;
                i++;
            }

            return -1;
        }

        public int[] ToArray()
        {
            Node current = Head;
            int i = 0;
            int[] value = new int[Length];
            while (current != null)
            {
                value[i] = current.value;
                current = current.Next;
                i++;
            }

            return value;
        }

        public int GetFirst()
        {
            
            if (Head == null)
            {
                throw new Exception("Error");
            }
            return Head.value;
        }

        public int GetLast()
        {
            if (Head == null)
            {
                throw new Exception("Error");
            }
            return Tail.value;
        }

        public int Get(int index)
        {
            if (index > Length - 1)
            {
                throw new Exception("Error");
            }

            Node current = Head;
            int i = 0;

            while (current != null)
            {
                if (i == index)
                {
                    break;
                }

                current = current.Next;
                i++;
            }

            return current.value;
        }

        public void Reverse()
        {
            Node current = Head;
            Node previous = null;

            while (current != null)
            {
                Node next = current.Next;
                current.Next = previous;
                previous = current;

                current = next;
            }

            Tail = Head;
            Head = previous;
        }

        public int Max()
        {
            if (Length == 0)
            {
                throw new Exception("Error!");
            }

            Node current = Head.Next;

            int max = Head.value;

            while (current != null)
            {
                if (current.value > max)
                {
                    max = current.value;
                }

                current = current.Next;
            }

            return max;
        }

        public int Min()
        {
            if (Length == 0)
            {
                throw new Exception("Error!");
            }

            Node current = Head.Next;

            int min = Head.value;

            while (current != null)
            {
                if (current.value < min)
                {
                    min = current.value;
                }

                current = current.Next;
            }

            return min;
        }

        public int IndexOfMax()
        {
            if (Length == 0)
            {
                throw new Exception("Error!");
            }

            Node current = Head.Next;
            int i = 1;
            int maxI = 0;
            int max = Head.value;
            while (current != null)
            {
                if (max < current.value)
                {
                    maxI = i;
                    max = current.value;
                }

                current = current.Next;
                i++;
            }

            return maxI;
        }

        public int IndexOfMin()
        {
            if (Length == 0)
            {
                throw new Exception("Error!");
            }

            Node current = Head.Next;
            int i = 1;
            int minI = 0;
            int min = Head.value;
            while (current != null)
            {
                if (min > current.value)
                {
                    minI = i;
                    min = current.value;
                }

                current = current.Next;
                i++;
            }

            return minI;
        }

        public void Sort()
        {
            Head = MergeSort(Head, false);
        }

        public void SortDesc()
        {
            Head = MergeSort(Head, true);
        }

        private Node MergeSort(Node n, bool desc)
        {
            if (n == null || n.Next == null)
            {
                return n;
            }

            Node middle = GetMiddle(n);
            Node nextofmiddle = middle.Next;

            middle.Next = null;

            if (desc)
            {
                return MergeSortedDesc(MergeSort(n, desc), MergeSort(nextofmiddle, desc));
            }

            return MergeSortedAsc(MergeSort(n, desc), MergeSort(nextofmiddle, desc));
        }

        private Node GetMiddle(Node n)
        {
            if (n == null)
            {
                return null;
            }

            Node fastptr = n.Next;
            Node slowptr = n;

            while (fastptr != null)
            {
                fastptr = fastptr.Next;
                if (fastptr != null)
                {
                    slowptr = slowptr.Next;
                    fastptr = fastptr.Next;
                }
            }

            return slowptr;
        }

        private Node MergeSortedAsc(Node n1, Node n2)
        {
            Node head = new Node(0);
            Node p = head;
            Node p1 = n1;
            Node p2 = n2;
            while (p1 != null && p2 != null)
            {
                if (p1.value < p2.value)
                {
                    p.Next = p1;
                    p1 = p1.Next;
                }
                else
                {
                    p.Next = p2;
                    p2 = p2.Next;
                }

                p = p.Next;
            }

            if (p1 != null)
            {
                p.Next = p1;
            }

            if (p2 != null)
            {
                p.Next = p2;
            }

            return head.Next;
        }

        private Node MergeSortedDesc(Node n1, Node n2)
        {
            Node head = new Node(0);
            Node p = head;
            Node p1 = n1;
            Node p2 = n2;
            while (p1 != null && p2 != null)
            {
                if (p1.value > p2.value)
                {
                    p.Next = p1;
                    p1 = p1.Next;
                }
                else
                {
                    p.Next = p2;
                    p2 = p2.Next;
                }

                p = p.Next;
            }

            if (p1 != null)
            {
                p.Next = p1;
            }

            if (p2 != null)
            {
                p.Next = p2;
            }

            return head.Next;
        }
    }
}