using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = TwoSum(new int[] { 1, 2, 3, 4 }, 5);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int i = 0, j = 0;
            bool isFound = false;
            for (i = 0; i < nums.Length - 1; i++)
            {
                if (!isFound)
                {
                    for (j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            isFound = true;
                            break;
                        }
                    }
                }
                else { break; }
            }
            return new int[] { i - 1, j };
        }


    }
}
