/*
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
Given two integers x and y, calculate the Hamming distance.
Note:
0 ≤ x, y < 231.

Example:
Input: x = 1, y = 4

Output: 2
Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461.HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 5;
            Console.WriteLine("{0}", new Program().HammingDistance(x,y));
            Console.ReadLine();
        }
        public int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            int distance = 0;
            while (xor > 0)
            {

                distance += xor & 1;
                xor = xor >> 1;
            }
            return distance;
        }
    }
}
