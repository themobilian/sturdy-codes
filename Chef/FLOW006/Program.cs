using System;

namespace CChef
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] N_Array = new int[T];
            for (int i = 0; i < T; i++)
            {
                N_Array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < T; i++)
            {
                int T_Sum = 0;
                while (N_Array[i] != 0)
                {
                    T_Sum += N_Array[i] % 10;
                    N_Array[i] = N_Array[i] / 10;
                }
                Console.WriteLine(T_Sum);
            }
        }
    }
}
