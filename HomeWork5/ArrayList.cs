namespace HomeWorkArrayList
{
    public class ArrayList
    {
        private int[] _array;

        public ArrayList(int[] array)
        {
            this._array = array;
        }

        public int[] AddFirst(int value)
        {
            int[] newArray = new int[_array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }

            _array = newArray;

            return _array;
        }

        public int[] AddFirst(int[] values)
        {
            int[] newArray = new int[_array.Length + values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                newArray[i] = values[i];
            }

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[values.Length + i] = _array[i];
            }

            _array = newArray;
            return _array;
        }

        public int[] AddLast(int value)
        {
            int[] newArray = new int[_array.Length + 1];
            newArray[newArray.Length - 1] = value;
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;

            return _array;
        }

        public int[] AddLast(int[] values)
        {
            int[] newArray = new int[_array.Length + values.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < values.Length; i++)
            {
                newArray[_array.Length + i] = values[i];
            }

            _array = newArray;
            return _array;
        }

        public int[] AddAt(int value, int idx)
        {
            int[] newArray = new int[_array.Length + 1];
            if (idx < 0 || idx > newArray.Length)
            {
                return new int[] { };
            }

            newArray[idx] = value;
            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = idx; i < newArray.Length - 1; i++)
            {
                newArray[i + 1] = _array[i];
            }

            _array = newArray;

            return _array;
        }

        public int[] AddAt(int[] value, int idx)
        {
            int[] newArray = new int[_array.Length + value.Length];
            if (idx < 0 || idx > newArray.Length)
            {
                return new int[] { };
            }

            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = 0; i < value.Length; i++)
            {
                newArray[i + idx] = value[i];
            }

            for (int i = 0; i < _array.Length - idx; i++)
            {
                newArray[i + value.Length + idx] = _array[idx + i];
            }

            _array = newArray;

            return _array;
        }

        public int GetSize()
        {
            return _array.Length;
        }

        public void Set(int idx, int value)
        {
            if (idx < 0 || idx > _array.Length)
            {
                return;
            }

            for (int i = 0; i < _array.Length; i++)
            {
                if (i == idx)
                {
                    _array[i] = value;
                }
            }
        }

        public void RemoveFirst()
        {
            if (_array.Length < 1)
            {
                return;
            }

            int[] newArray = new int[_array.Length - 1];


            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + 1];
            }

            _array = newArray;
        }

        public void RemoveLast()
        {
            if (_array.Length < 1)
            {
                return;
            }

            int[] newArray = new int[_array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public void RemoveAt(int idx)
        {
            int[] newArray = new int[_array.Length - 1];
            if (idx < 0 || idx > newArray.Length)
            {
                return;
            }

            for (int i = 0; i < idx; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = idx; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + 1];
            }

            _array = newArray;
        }

        public void RemoveAll(int value)
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
            }

            int[] newArray = new int[_array.Length - count];
            int q = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] != value)
                {
                    newArray[q] = _array[i];
                    q++;
                }
            }

            _array = newArray;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public int[] ToArray()
        {
            return _array;
        }

        public int GetFirst()
        {
            if (_array.Length < 1)
            {
                return 0;
            }

            return _array[0];
        }

        public int GetLast()
        {
            if (_array.Length < 1)
            {
                return 0;
            }

            return _array[_array.Length - 1];
        }

        public int Get(int idx)
        {
            if (idx < 0 || idx > _array.Length)
            {
                return 0;
            }

            return _array[idx];
        }

        public void Reverse()
        {
            for (int i = 0; i < _array.Length / 2; i++)
            {
                int temp = _array[_array.Length - i - 1];
                _array[_array.Length - i - 1] = _array[i];
                _array[i] = temp;
            }
        }

        public int Max()
        {
            if (_array.Length < 1)
            {
                return 0;
            }

            int max = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int Min()
        {
            if (_array.Length < 1)
            {
                return 0;
            }

            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }

        public int IndexOfMax()
        {
            if (_array.Length < 1)
            {
                return -1;
            }

            int maxI = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > maxI)
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public int IndexOfMin()
        {
            if (_array.Length < 1)
            {
                return -1;
            }

            int minI = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < minI)
                {
                    minI = i;
                }
            }

            return minI;
        }

        public void Sort()
        {
            QuickSort(_array, 0, _array.Length - 1);
        }

        private void QuickSort(int[] data, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int pi = Partition(data, low, high);

            QuickSort(data, low, pi - 1);
            QuickSort(data, pi + 1, high);
        }

        private int Partition(int[] data, int low, int high)
        {
            int i = low - 1, temp;

            for (int j = low; j <= high - 1; j++)
            {
                if (data[j] < data[high])
                {
                    i++;

                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
            }

            temp = data[high];
            data[high] = data[i + 1];
            data[i + 1] = temp;

            return i + 1;
        }

        public void SortDesc()
        {
            QuickSortDesc(_array, 0, _array.Length - 1);
        }

        private void QuickSortDesc(int[] data, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int pi = PartitionDesc(data, low, high);

            QuickSortDesc(data, low, pi - 1);
            QuickSortDesc(data, pi + 1, high);
        }

        private int PartitionDesc(int[] data, int low, int high)
        {
            int i = low - 1, temp;

            for (int j = low; j <= high - 1; j++)
            {
                if (data[j] > data[high])
                {
                    i++;

                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                }
            }

            temp = data[high];
            data[high] = data[i + 1];
            data[i + 1] = temp;

            return i + 1;
        }
    }
}