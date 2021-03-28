using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class LinkedListTests
    {
        [TestCase(3, new int[] { 1, 2 }, new int[] { 1, 2, 3 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 2, 35, 1 })]
        public void Add_WhenValuePassed_ShouldAddValueToLast(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 2 }, new int[] { 3, 1, 2 })]
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { 1, 2, 35 }, new int[] { 1, 1, 2, 35 })]
        public void AddValueToStart_WhenValuePassed_ShouldValueToStart(int value, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddValueToStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0, new int[] { 1, 2, 3 }, new int[] { 7, 1, 2, 3 })]
        [TestCase(5, 1, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        [TestCase(3, 2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 3, 4 })]
        public void AddValueByIndex_WhenValueAndIndexPassed_ShouldAddValueByIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        public void RemoveOneElementFromLast_WhenMethodCalledPassed_ShouldRemoveLast(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveOneElementFromLast();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        public void RemoveOneElementFromStart_WhenMethodCalledPassed_ShouldRemoveFirstElem(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveOneElementFromStart();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1, 6, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(2, new int[] { 1, 2, 5, 3, }, new int[] { 1, 2, 3 })]
        public void RemoveOneElementByIndex_WhenElementPassed_ShouldRemoveElement(int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2 })]

        public void Remove_NElementsFromLast_WhenNElementsPassed_ShouldRemoveNElements(int nvalue, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemovNElementsFromLast(nvalue);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5 })]
        [TestCase(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5 })]

        public void RemoveNElementsFromStart_WhenNElementsPassed_ShouldRemoveNElements(int nvalue, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveNElementsFromStart(nvalue);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 3 })]
        [TestCase(2, 2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5 })]
        public void RemoveNElementsByIndex_WhenIndexAndNElementsPassed_ShouldRemoveByIndexNElements( int nvalue,int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveNElementsByIndex(nvalue,index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
        [TestCase(10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, -1)]
        [TestCase(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void GetFirstIndexByValue_WhenValuePassed_ShouldReturnIndex(int value, int[] actualArray, int expected)
        {
            LinkedList array = new LinkedList(actualArray);

            int actual = array.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 2, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 2, 4, 5, 6, 7, 8 })]
        [TestCase(10, 0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 10, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(1, 7, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 1 })]

        public void GetChangeByIndex_WhenValue_ReturnIndex(int value, int index, int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.GetChangeByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        //[TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 10, 2, 3, 4, 5, 6, 7, 8 })]
        //[TestCase( new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 1 })]

        public void Revers(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.Revers();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        public void GetIndexMaxElement_WhenMethodCalledPassed_ShouldReturnMaxIndex(int[] actualArray, int expected)
        {
            LinkedList list = new LinkedList(actualArray);
            int actual = list.GetIndexMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, 7)]
        public void GetIndexOfMinElement_WhenMethodCalledPassed_ShouldReturnMaxIndex(int[] actualArray, int expected)
        {
            LinkedList list = new LinkedList(actualArray);
            int actual = list.GetIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        [TestCase(new int[] { 3, 5, -2, 28, 16 }, 3)]
        public void GetValueMaxElement_WhenMethodCalledPassed_ShouldReturnMaxElement(int[] actualArray, int expected)
        {
            LinkedList list = new LinkedList(actualArray);
            int actual = list.GetValueMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 0)]
        [TestCase(new int[] { 3, 5, -2, 28, 16 }, 2)]
        public void GetValueMinElement_WhenMethodCalledPassed_ShouldReturnMaxElement(int[] actualArray, int expected)
        {
            LinkedList list = new LinkedList(actualArray);
            int actual = list.GetValueMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { -1, 1, 1, 3, 4, 6, 8, 12 })]
        [TestCase(new int[] { 2, 1, 8, 16, 11 }, new int[] { 1, 2, 8, 11, 16 })]
        [TestCase(new int[] { 8, 1, 18, 16, 11 }, new int[] { 1, 8, 11, 16, 18 })]
        public void GetSortAscending_WhenMethodCalledPassed_ShouldSortbyAscending(int[] actualArray, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(actualArray);
            LinkedList expected = new LinkedList(expectedArray);

            actual.GetSortAscending();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { }, new int[] { })]
        //[TestCase(new int[] { 1, 3, -1, 4, 1, 6, 8, 12 }, new int[] { 12, 8, 6, 4, 3, 1, 1, -1 })]
        //public void GetDescendingSort_WhenMethodCalledPassed_ShouldSortbyAscending(int[] actualArray, int[] expectedArray)
        //{
        //    LinkedList actual = new LinkedList(actualArray);
        //    LinkedList expected = new LinkedList(expectedArray);

        //    actual.GetDescendingSort();

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(7, new int[] { 7, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        //[TestCase(2, new int[] { 1, 5, 2, 3 }, new int[] { 1, 5, 3 })]
        //[TestCase(7, new int[] { 1, 2, 3, 7 }, new int[] { 1, 2, 3 })]

        //public void RemoveByValueOfTheFirst_WhenElementByValuePassed_ShouldRemoveValue(int value, int[] actualArray, int[] expectedArray)
        //{
        //    LinkedList actual = new LinkedList(actualArray);
        //    LinkedList expected = new LinkedList(expectedArray);

        //    actual.RemoveByValueOfTheFirst(value);

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { 2, 1, 2, 4, 2, 6, 7, 8 }, 2, new int[] { 1, 4, 6, 7, 8 })]
        //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        //[TestCase(new int[] { 1, 1, 3, 4, 5, 6, 8, 8 }, 10, new int[] { 1, 1, 3, 4, 5, 6, 8, 8 })]
        //[TestCase(new int[] { 3, 3, 3 }, 3, new int[] { })]
        //public void RemoveAllByValue_WhenValue_ShouldRemoveAllValue(int[] actualArray, int value, int[] expectedArray)
        //{
        //    LinkedList actual = new LinkedList(actualArray);
        //    LinkedList expected = new LinkedList(expectedArray);

        //    actual.RemoveByValueAll(value);

        //    Assert.AreEqual(expected, actual);
        //}



    }
}
