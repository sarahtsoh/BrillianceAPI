using BrillianceAPI.Services;
using System;
using Xunit;
using System.Linq;

namespace XUnitTestProject1
{
    public class CalArrayTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 3, 5, 7, 9 })]
        public void ReverseArrayTest(int[] array)
        {
            var service = new ArrayCalService();
            var result = service.ReverseArray(array);
            var testArray = array.Reverse().ToArray();
            Assert.Equal(testArray, result);

        }


        [Theory]
        [InlineData(3, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(4, new int[] { 1, 3, 5, 7, 9 })]
        public void DeletePartArray(int position, int[] array)
        {
            var service = new ArrayCalService();
            var result = service.DeletePartArray(position, array);
            var testArray = array.ToList();
            testArray.RemoveAt(position-1);
            Assert.Equal(testArray, result);

        }




    }
}
