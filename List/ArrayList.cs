using System;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;
        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }
        public ArrayList(int value)
        {
            Length = 0;
            _array = new int[10];
            _array[0] = value;
        }
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = value;
            Resize();
        }
        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        public override bool Equals(object obj)
        {
            ArrayList list = (ArrayList)obj;
            if (this.Length != list.Length)
            {
                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != list._array[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < Length; i++)
            {
                result += _array[i] + " ";

            }

            result.Trim();
            return result;
        }
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                Resize();
            }
            _array[Length] = value;
            Length++;
        }
        public void AddValueToBeginning(int value)
        {
            Resize();

            for (int i = Length - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[0] = _array[value];
            ++Length;
        }
        public void AddValueByIndex(int value, int index)
        {
            if (index <= Length && index >= 0)
            {

                if (Length >= _array.Length)
                {
                    Resize();
                }

                for (int i = Length - 1; i >= index; i--)
                {
                    _array[i + 1] = _array[i];
                }
                _array[index] = value;
                ++Length;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveOneElementFromTheEnd()
        {
            Length--;

            Resize();
        }
        public void RemoveOneElementFromTheBeginning()
        {
           
        }
        public void RemoveOneElementByIndex(int index)
        {
            if (index < Length && index >= 0)
            {

                for (int i = index; i < Length; i++)
                {
                    _array[i] = _array[i + 1];
                }

                Length--;
                Resize();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveNElementsFromTheEnd(int Nvalue)
        {
            if (Nvalue < Length && Nvalue >= 0)
            {
                Length -= Nvalue;

                Resize();
            }
        }
        public void RemoveNElementsFromTheBeginning(int Nvalue)
        {
            if (Nvalue < Length && Nvalue >= 0)
            {
                for (int i = Nvalue; i <= Length; i++)
                {
                    _array[i - Nvalue] = _array[i];
                }

                Length -= Nvalue;
                Resize();
            }
        }
        public void RemoveNElementsByIndex(int Nvalue, int Index)
        {
            if (Index < Length && Index >= 0 && Length - Nvalue > 0)
            {

                for (int i = Index + Nvalue; i <= Length; i++)
                {
                    _array[i - Nvalue] = _array[i];
                }

                Length -= Nvalue;
                Resize();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int GetFirstIndexByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    return i;
                }
            }

           return -1;
        }

        public void GetReverse()
        {
           
        }
        public void FindTheValueOfTheMaxElement(int value)
        {
            
        }
        public void FindTheValueOfTheMinElement(int value)
        {
            
        }
        public int SearchIndexOfMaxElement(int value)
        {
            if (!(Length == 0))
            {

                int maxIndexOfElement = 0;

                for (int i = 1; i < Length; i++)
                {
                    if (_array[maxIndexOfElement] < _array[i])
                    {
                        maxIndexOfElement = i;
                    }
                }

                return maxIndexOfElement;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public int SearchIndexOfMinElement(int value)
        {
            if (!(Length == 0))
            {

                int minIndexOfElement = 0;

                for (int i = 1; i < Length; i++)
                {
                    if (_array[minIndexOfElement] > _array[i])
                    {
                        minIndexOfElement = i;
                    }
                }

                return minIndexOfElement;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void GetSortAscending()
        {
            int j;
            int temp;

            for (int i = 1; i < Length; i++)
            {
                j = i;
                temp = _array[i];

                while (j > 0 && temp < _array[j - 1])
                {
                    _array[j] = _array[j - 1];
                    j--;
                }

                _array[j] = temp;
            }
        }
        public void GetDescendingSort()
        {
            int j;
            int temp;

            for (int i = 1; i < Length; i++)
            {
                j = i;
                temp = _array[i];

                while (j > 0 && temp > _array[j - 1])
                {
                    _array[j] = _array[j - 1];
                    j--;
                }

                _array[j] = temp;
            }
        }
        public void DeleteByValueOfTheFirst()
        {

        }
        public void DeleteByValueAll()
        {

        }
        public void AddListToTheEnd()
        {

        }
        public void AddListToTheBeginning()
        {

        }
        public void AddListByIndex()
        {

        }

        private void Resize()
        {
            if (Length >= _array.Length)
            {
                int newLenght = (int)(Length * 1.33 + 1);
                int[] tmpArray = new int[newLenght];

                for (int i = 0; i < Length; i++)
                {
                    tmpArray[i] = _array[i];
                }

                _array = tmpArray;
            }
        }
    }
}
