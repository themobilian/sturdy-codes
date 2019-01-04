/*
Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.  For example, flipping [1, 1, 0] horizontally results in [0, 1, 1].

To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting [0, 1, 1] results in [1, 0, 0].

Example 1:

Input: [[1,1,0],[1,0,1],[0,0,0]]
Output: [[1,0,0],[0,1,0],[1,1,1]]
Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]
Example 2:

Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
Notes:

1 <= A.length = A[0].length <= 20
0 <= A[i][j] <= 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _832.FlippingAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
            //[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
            int[][] input = new int[][] { new int[]{ 1, 1, 0, 0 }, new int[] { 1, 0, 0, 1 }, new int[] { 0, 1, 1, 1 }, new int[] { 1, 0, 1, 0} };
            Console.WriteLine("{0}", new Program().FlipAndInvertImage(input));
            Console.ReadLine();
        }
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int maxIndexI = A[0].Length;
            int maxIndexJ = (maxIndexI%2==0)? (maxIndexI/2)-1: maxIndexI/2;
            for (int i = 0; i < maxIndexI; i++)
            {
                for (int j = 0; j <= maxIndexJ; j++)
                {
                    int leftTemp = A[i][j];
                    int RightTemp = A[i][maxIndexI - j - 1];
                    A[i][j] = (RightTemp == 0 ? 1 : 0);
                    A[i][maxIndexI - j - 1] = (leftTemp == 0 ? 1 : 0);
                }
            }
            return A;
        }
    }
}
