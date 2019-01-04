/*
Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.

Example 1:

Input: [3,1,2,4]
Output: [2,4,3,1]
The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.
 
Note:

1 <= A.length <= 5000
0 <= A[i] <= 5000
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _905.SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 3, 1, 2, 4 };
            Console.WriteLine("{0}", new Program().SortArrayByParity(input));
            Console.ReadLine();
        }
        public int[] SortArrayByParity(int[] A)
        {
            int[] parityArray = new int[A.Length];
            int evenIndexer = 0;
            int oddIndexer = A.Length-1;
            foreach (int i in A)
            {
                if (i % 2 == 0)
                {
                    parityArray[evenIndexer++]=i;
                }
                else
                {
                    parityArray[oddIndexer--] = i;
                }
            }
            return parityArray;
        }
    }
}
