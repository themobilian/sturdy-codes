/*
In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.

Return the element repeated N times.

 
Example 1:

Input: [1,2,3,3]
Output: 3
Example 2:

Input: [2,1,2,5,3,2]
Output: 2
Example 3:

Input: [5,1,5,2,5,3,5,4]
Output: 5
 
Note:

4 <= A.length <= 10000
0 <= A[i] < 10000
A.length is even
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _961.NRepeatedElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[]{ 1, 2, 3, 3 };
            Console.WriteLine("{0}",new Program().RepeatedNTimes(A));
            Console.ReadLine();
        }
        public int RepeatedNTimes(int[] A)
        {
            int repeatedNum = A[0];
            int len = A.Length;
            bool isFound = false;
            for (int i = 0; i < len; i++)
            {
                if (!isFound)
                {
                    for (int j = i+1; j < len; j++)
                    {
                        if (A[i] == A[j])
                        {
                            repeatedNum = A[i];
                            isFound = true;
                            break;
                        }
                    }
                }
                else { break; }
            }
            return repeatedNum;
        }
    }
}
