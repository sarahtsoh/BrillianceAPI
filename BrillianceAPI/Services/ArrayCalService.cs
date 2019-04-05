using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrillianceAPI.Services
{
    public class ArrayCalService : IArrayCalService
    {
        public int[] ReverseArray(int[] inputArray)
        {
            var length = inputArray.Length;

            var reverseArray = new int[length];


            for (int i = 0; i < length; i++)
            {
                int j = length - i - 1;
                reverseArray[i] = inputArray[j];

            }

            return reverseArray;

        }

        public int[] DeletePartArray(int position, int[] inputArray)
        {
           
            var length = inputArray.Length;

            if (position == 0 || position > length)
                return inputArray;

            var newArrayLength = length - 1;

            var newArray = new int[newArrayLength];

            var delIndex = position - 1;

            for (int i = 0; i < newArrayLength; i++)
            {
                int j = i;
                if (i >= delIndex)
                    j = i + 1;

                newArray[i] = inputArray[j];

            }

            return newArray;

        }


    }
}
