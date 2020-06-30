using System;

namespace HomeWorkDoublyLinkedList
{
    public class DoublyNode
    {
        public int Value { get; set; }

        public DoublyNode Prev { get; set; }
        public DoublyNode Next { get; set; }

        public DoublyNode(int value)
        {
            this.Value = value;
        }
    }

    public class DoublyLinkedList
    {
        public DoublyNode Head { get; set; }
        public int Length { get; set; }
        public DoublyNode Tail { get; set; }

        public DoublyLinkedList()
        {
            Length = 0;
        }

        public DoublyLinkedList(int[] value)
        {
            if (value.Length == 0)
            {
                Length = 0;
                Head = null;
                Tail = null;
                return;
            }

            Head = new DoublyNode(value[0]);
            Tail = Head;

            for (int i = 1; i < value.Length; i++)
            {
                DoublyNode node = new DoublyNode(value[i]);
                node.Prev = Tail;
                Tail.Next = node;
                Tail = Tail.Next;
            }

            Length = value.Length;
        }


        public void AddFirst(int value)
        {
            DoublyNode node = new DoublyNode(value);
            Length++;

            if (Head == null)
            {
                Head = node;
                Tail = node;                
                return;
            }

            node.Next = Head;
            Head.Prev = node;
            Head = node;
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
            DoublyNode node = new DoublyNode(value);

            if (Length == 0)
            {
                Tail = node;
                Head = node;
                Length = 1;
                return;
            }

            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
            Length++;
        }

        public void AddLast(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                AddLast(values[i]);
            }
        }

        public void AddAt(int index, int value)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new Exception("Error");
            }

            DoublyNode node = new DoublyNode(value);
            if (index == 0)
            {
                DoublyNode temp = Head;
                Head = node;
                Head.Next = temp;
                temp.Prev = Head;
                Length++;
                return;
            }

            DoublyNode before = Head;
            for (int i = 1; i < index; i++)
            {
                before = before.Next;
            }

            node.Next = before.Next;
            node.Prev = before;
            before.Next = node;
            if (node.Next != null)
            {
                node.Next.Prev = node;
            }

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

            DoublyLinkedList newList = new DoublyLinkedList(values);


            DoublyNode before = Head;
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

            DoublyNode current = Head;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }

            current.Value = value;
        }

        public void RemoveFirst()
        {
            switch (Length)
            {
                case 0:
                    throw new Exception("Error");                   
                case 1:
                    Head = null;
                    Tail = null;
                    Length = 0;
                    break;
                default:
                    Head = Head.Next;
                    Head.Prev = null;
                    Length--;
                    break;
            }
        }

        public void RemoveLast()
        {
            switch (Length)
            {
                case 0:
                    throw new Exception("Error");
                case 1:
                    Head = null;
                    Tail = null;
                    Length = 0;
                    break;
                default:
                    Tail = Tail.Prev;
                    Tail.Next = null;                    
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

            DoublyNode before = Head;
            for (int i = 1; i < index; i++)
            {
                before = before.Next;
            }
            before.Next.Next.Prev = before;
            before.Next = before.Next.Next;
            Length--;
        }

        public void RemoveAll(int value)
        {
            DoublyNode current = Head;
            int i = 0;

            while (current != null)
            {
                if (current.Value == value)
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
            DoublyNode current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }


        public int IndexOf(int value)
        {
            DoublyNode current = Head;
            int i = 0;
            while (current != null)
            {
                if (current.Value == value)
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
            DoublyNode current = Head;
            int i = 0;
            int[] value = new int[Length];
            while (current != null)
            {
                value[i] = current.Value;
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
            return Head.Value;
        }

        public int GetLast()
        {
            if (Head == null)
            {
                throw new Exception("Error");
            }
            return Tail.Value;
        }

        public int Get(int index)
        {
            if (index > Length - 1)
            {
                throw new Exception("Error");
            }

            DoublyNode current = Head;
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

            return current.Value;
        }

        public void Reverse()
        {
            DoublyNode current = Head;
            DoublyNode previous = null;

            while (current != null)
            {
                DoublyNode next = current.Next;
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

            DoublyNode current = Head.Next;

            int max = Head.Value;

            while (current != null)
            {
                if (current.Value > max)
                {
                    max = current.Value;
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

            DoublyNode current = Head.Next;

            int min = Head.Value;

            while (current != null)
            {
                if (current.Value < min)
                {
                    min = current.Value;
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

            DoublyNode current = Head.Next;
            int i = 1;
            int maxI = 0;
            int max = Head.Value;
            while (current != null)
            {
                if (max < current.Value)
                {
                    maxI = i;
                    max = current.Value;
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

            DoublyNode current = Head.Next;
            int i = 1;
            int minI = 0;
            int min = Head.Value;
            while (current != null)
            {
                if (min > current.Value)
                {
                    minI = i;
                    min = current.Value;
                }

                current = current.Next;
                i++;
            }

            return minI;
        }

        /*public void Sort()
        {
           
            DoublyNode a = Head;
            while(a != null)
            {
                 if(a.Next == null) return;        
                 DoublyNode b = a.Next;
                 if(a.Value > b.Value)
                 {
                    DoublyNode aPrev = a.Prev;
                    DoublyNode bNext = b.Next;
                    if (aPrev != null)
                    {
                        aPrev.Next = b;
                    }
                    b.Prev = aPrev;
                    if(bNext != null)
                    {
                        bNext.Prev = a;
                    }                  
                    a.Next = bNext;
                    b.Next = a;
                    a.Prev = b;

                 }
                 else
                 {
                    a = a.Next;
                 }

                
            }
        }*/

        public void Sort()
        {
            Head = MergeSort(Head, false);
        }

        public void SortDesc()
        {
            Head = MergeSort(Head, true);
        }

        private DoublyNode MergeSort(DoublyNode n, bool desc)
        {
            if (n == null || n.Next == null)
            {
                return n;
            }

            DoublyNode middle = GetMiddle(n);
            DoublyNode nextofmiddle = middle.Next;

            middle.Next = null;

            if (desc)
            {
                return MergeSortedDesc(MergeSort(n, desc), MergeSort(nextofmiddle, desc));
            }

            return MergeSortedAsc(MergeSort(n, desc), MergeSort(nextofmiddle, desc));
        }

        private DoublyNode GetMiddle(DoublyNode n)
        {
            if (n == null)
            {
                return null;
            }

            DoublyNode fastptr = n.Next;
            DoublyNode slowptr = n;

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

        private DoublyNode MergeSortedAsc(DoublyNode n1, DoublyNode n2)
        {
            DoublyNode head = new DoublyNode(0);
            DoublyNode p = head;
            DoublyNode p1 = n1;
            DoublyNode p2 = n2;
            while (p1 != null && p2 != null)
            {
                if (p1.Value < p2.Value)
                {
                    p.Next = p1;
                    p1.Prev = p;
                    p1 = p1.Next;
                }
                else
                {
                    p.Next = p2;
                    p2.Prev = p;
                    p2 = p2.Next;
                }

                p = p.Next;
            }

            if (p1 != null)
            {
                p.Next = p1;
                p1.Prev = p;
            }

            if (p2 != null)
            {
                p.Next = p2;
                p2.Prev = p;
            }

            return head.Next;
        }

        private DoublyNode MergeSortedDesc(DoublyNode n1, DoublyNode n2)
        {
            DoublyNode head = new DoublyNode(0);
            DoublyNode p = head;
            DoublyNode p1 = n1;
            DoublyNode p2 = n2;
            while (p1 != null && p2 != null)
            {
                if (p1.Value > p2.Value)
                {
                    p.Next = p1;
                    p1.Prev = p;
                    p1 = p1.Next;
                }
                else
                {
                    p.Next = p2;
                    p2.Prev = p;
                    p2 = p2.Next;
                }

                p = p.Next;
            }

            if (p1 != null)
            {
                p.Next = p1;
                p1.Prev = p;
            }

            if (p2 != null)
            {
                p.Next = p2;
                p2.Prev = p;
            }

            return head.Next;
        }
    }
}