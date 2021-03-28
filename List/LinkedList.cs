using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class LinkedList
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] values)
        {
            if (values != null)
                Length = values.Length;

            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public void Add(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        public void AddValueToStart(int value)
        {
            Length++;

            Node first = new Node(value);

            first.Next = _root;
            _root = first;
        }

        public void AddValueByIndex(int value, int index)
        {
            if (index >= 0 && index <= Length)
            {
                if (Length != 0)
                {
                    if (index == 0)
                    {
                        AddValueToStart(value);
                        Length--;
                    }
                    else
                    {
                        Node nodeByIndex = new Node(value);

                        Node current = GetNodeByIndex(index - 1);

                        nodeByIndex.Next = current.Next;
                        current.Next = nodeByIndex;
                    }
                }
                else
                {
                    _root = new Node(value);
                    _tail = _root;
                }

                Length++;
            }
            else
            {
                throw new IndexOutOfRangeException("Error");
            }

        }
        public void RemoveOneElementFromLast()
        {
            RemoveOneElementByIndex(Length - 1);
        }
        public void RemoveOneElementFromStart()
        {
            _root = _root.Next;
            Length--;
        }
        public void RemoveOneElementByIndex(int index)
        {
            if (index >= 0 && index <= Length)
            {
                if (Length != 0)
                {
                    if (index != 0)
                    {
                        Node current = _root;

                        for (int i = 1; i < index; i++)
                        {
                            current = current.Next;
                        }

                        current.Next = current.Next.Next;

                        Length--;
                    }
                    else
                    {
                        RemoveOneElementFromStart();
                    }
                }
                else
                {
                    Length = 0;
                    _root = null;
                    _tail = null;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Error");
            }
        }
        public void RemovNElementsFromLast(int nvalue) 
        {
            if (nvalue != Length)
            {
                Node current = GetNodeByIndex(Length - nvalue);
                current.Next = _tail;

                Length -= nvalue;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }
        public void RemoveNElementsFromStart(int nvalue)
        {
            if (nvalue != Length)
            {
                Node current = GetNodeByIndex(nvalue - 1);
                _root = current.Next;

                Length -= nvalue;
            }
            else
            {
                Length = 0;
                _root = null;
                _tail = null;
            }
        }
        public void RemoveNElementsByIndex(int nvalue, int index)
        {
            if (index >= 0 && index < Length)
            {
                if (index == 0)
                {
                    RemoveNElementsFromStart(nvalue);
                }
                else if (nvalue == Length - 1)
                {
                    RemovNElementsFromLast(nvalue);
                }
                else if (nvalue > 0)
                {
                    if (!(nvalue + index >= Length))
                    {
                        Node startNode = GetNodeByIndex(index - 1);
                        Node finishNode = GetNodeByIndex(index + nvalue);

                        startNode.Next = finishNode;

                        Length -= nvalue;
                    }
                    else
                    {
                        Node current = GetNodeByIndex(index);

                        current.Next = null;
                        _tail = current;
                        Length = index;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid value!");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Error!");
            }
        }
        public void GetChangeByIndex(int index, int value)
        {
            if (index >= 0 && index <= Length)
            {
                Node current = GetNodeByIndex(index);

                current.Value = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Error");
            }

        }
        public int GetFirstIndexByValue(int value)
        {
            Node current = _root;

            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }
        public void Revers()
        {
            Node prev = null;
            Node next = null;
            Node current = _root;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            _root = prev;
        }
        
        public int GetIndexMaxElement()
        {
            Node current = _root;
            int maxIndex = 0;
            int temp = 0;

            for (int i = 0; i < Length; i++)
            {
                if (temp < current.Value)
                {
                    maxIndex = i;
                    temp = current.Value;
                }

                current = current.Next;
            }

            return maxIndex;
        }
        public int GetIndexOfMinElement()
        {
            {

                Node current = _root;
                int minIndex = 0;
                int temp = current.Value;

                for (int i = 0; i < Length; i++)
                {
                    if (temp > current.Value)
                    {
                        minIndex = i;
                        temp = current.Value;
                    }

                    current = current.Next;
                }

                return minIndex;
            }
        }
        public int GetValueMaxElement()
        {
            return GetIndexMaxElement();
        }
        public int GetValueMinElement()
        {
            return GetIndexOfMinElement();
        }
        public override string ToString()
        {
            if (Length != 0)
            {
                Node current = _root;
                string s = current.Value + " ";

                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }

                return s;
            }
            else
            {
                return String.Empty;
            }
        }
        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;

            if (this.Length != list.Length)
            {
                return false;
            }

            Node currentThis = this._root;
            Node currentList = list._root;

            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            while (!(currentThis.Next is null));

            return true;
        }
        private Node GetNodeByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }
            return current;
        }

    }
}
