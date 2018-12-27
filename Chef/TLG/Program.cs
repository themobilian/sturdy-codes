using System;

namespace CChef
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int lead = 0, p1=0,p2=0, p1maxlead=0,p2maxlead=0;
            while (N-->0)
            {
                string[] scores = Console.ReadLine().Split();
                p1 += int.Parse(scores[0]);
                p2 += int.Parse(scores[1]);

                lead = p1 - p2;
                if (lead < 0)
                {
                    lead = -lead;
                    if (p2maxlead < lead)
                    {
                        p2maxlead = lead;
                    }
                }
                else
                {
                    if (p1maxlead < lead)
                    {
                        p1maxlead = lead;
                    }
                }
            }
            if (p1maxlead < p2maxlead)
            {
                Console.WriteLine("{0} {1}", 2, p2maxlead);
            }
            else
            {
                Console.WriteLine("{0} {1}", 1, p1maxlead);
            }
        }
    }
}
