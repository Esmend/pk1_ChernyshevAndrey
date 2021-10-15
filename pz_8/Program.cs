using System;
using System.Linq;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 20;
            int[] A = new int[a];
            Console.WriteLine("Массив А: ");
            Random rnd = new Random();
            int i;
            for (i = 0; i <= (a - 1); i++) 
            {
                A[i]=rnd.Next(0, 20);
                Console.Write(" " + A[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] uniq = A.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).ToArray();
            foreach (int f in uniq )
            {
                Console.Write(" " + f) ;
            }

        }
    }
}
