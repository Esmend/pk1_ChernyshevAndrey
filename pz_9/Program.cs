using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            Random rnd = new Random();
            Console.WriteLine("Массив А: ");
            for (int y = 0; y < A.GetLength(0); y++)
            {
                for (int x = 0; x < A.GetLength(1); x++)
                {
                    A[x, y] = rnd.Next(0, 5);
                    Console.Write(A[x, y] + " ");
                }
                Console.WriteLine();
            }

            int min = A[1, 2];

            for (int y = 1; y < A.GetLength(0); y++)
            {
                for (int x = 1; x < A.GetLength(1); x++)
                {
                    if (x >= 1 && y >= 1 && !(x == 1 && y == 1))
                    {
                        if (min > A[x, y])
                            min = A[x, y];
                    }
                }
            }
            Console.WriteLine("Минимальное значение:");
            Console.WriteLine(min);
            Console.WriteLine("Часть ниже Побочной диагонали:");

            for (int y = 1; y < A.GetLength(0); y++)
            {
                for (int x = 1; x < A.GetLength(1); x++)
                {
                    if (x >= 1 && y >= 1 && !(x == 1 && y == 1))
                    {
                        Console.Write(A[x, y]);
                    }
                }
            }
          
        }
    }
}
