using NUnit.Framework;

namespace List.Tests
{
    public class ArrayListTests
    {
        [TestCase(10, 1, 2)]
        public void Add_WhenIntValue_ShouldToEnd(int value, int  mockNumb, int expectedMockNumb)
        {
            
            ArrayList actual = new ArrayList(ArrayListMock.GetIntArrayListMock(mockNumb,value));
            actual.Add(value);
            ArrayList expected = new ArrayList(ArrayListMock.GetIntArrayListMock(expectedMockNumb,value));

            Assert.AreEqual(expected, actual);
        }

        public static class ArrayListMock
        {
            public static int[] GetIntArrayListMock(int numb, int value)
            {
                int[] a = new int[0];
                switch (numb)
                {
                    case 1:
                        a = new int[] { 8, 6, 2, 4 };
                        break;
                    case 2:
                        a = new int[] { 8, 6, 2, 4, value };
                        break;
                    case 3:
                        a = new int[] { value, 8, 6, 2, 4 };
                        break;
                }
                return a;

            }
        }
    }
}
