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
            UpSize();
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
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
        public void AddValueToBeginning(int value)
        {

        }
        public void AddValueByIndex(int index)
        {

        }
        public void RemoveOneElementFromTheEnd(int value)
        {
           
        }
        public void RemoveOneElementFromTheBeginning(int value)
        {
            for (int i = Length - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            Length--;
            
        }
        public void RemoveOneElementByIndex(int value)
        {

        }
        public void RemoveNElementsFromTheEnd(int value)
        {

        }
        public void RemoveNElementsFromTheBeginning(int value)
        {

        }
        public void RemoveNElementsByIndex()
        {

        }
        public void GetIndexAccess()
        {

        }
        public void GetFirstIndexByValue()
        {

        }
        public void ChangeByIndex()
        {

        }
        public void GetReverse()
        {
            int[] result = new int[_array.Length];
            int j = 0;
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                result[j] = _array[i];
                j++;
            }
        }
        public void FindTheValueOfTheMaxElement()
        {
            int max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }
        }
        public void FindTheValueOfTheMinElement()
        {
            int min = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }
        }
        public void SearchIndexOfMaxElement()
        {
            int max = _array[0];
            for (int i = 1; i < _array.Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }
        }
        public void SearchIndexOfMinElement()
        {
            int min = _array[0];
            int minIndex = 0;
            for (int i = 1; i < _array.Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    minIndex = i;
                }
            }
        }
        public void GetSortAscending()
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                int min = i;

                if (min > _array[i])
                {
                    min = _array[i];
                }

                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                int temp = _array[min];
                _array[min] = _array[i];
                _array[i] = temp;
            }
    }
        public void GetDescendingSort()
        {
        for (int i = 1; i < _array.Length; i++)
        {
            int j = i;

            while (j > 0 && _array[j] > _array[j - 1])
            {
                int temp = _array[j];
                _array[j] = _array[j - 1];
                _array[j - 1] = temp;

                j--;
            }
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
    }
}
