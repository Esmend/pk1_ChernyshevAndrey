using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //создание ступенчатого массива
            int[][] arr = new int[5][];

            arr[0] = new int[rand.Next(2, 31)];
            arr[1] = new int[rand.Next(2, 31)];
            arr[2] = new int[rand.Next(2, 31)];
            arr[3] = new int[rand.Next(2, 31)];
            arr[4] = new int[rand.Next(2, 31)];

            //заполнение массива рандомными символами
            for (int y = 0; y < arr.Length; y++)
            {
                for (int x = 0; x < arr[y].Length; x++)
                {
                    arr[y][x] = Convert.ToChar(rand.Next(0,11));
                }
            }

            //вывод массива
            Console.WriteLine("Ступенчатый массив");

            foreach (int[] row in arr)
            {
                foreach (int symbol in row)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }

            //массив последних элементов зубчатого массива
            int[] lastVals = new int[arr.Length];

            for (int i = 0; i < lastVals.Length; i++)
            {
                lastVals[i] = arr[i][^1];
            }

            //вывод элементов массива lastVal
            Console.Write("\nПоследние элементы каждой строки: ");
            foreach (int ch in lastVals)
            {
                Console.Write($"{ch} ");
            }

            //массив старших элементов каждой строки
            int[] maxVals = new int[arr.Length];

            for (int i = 0; i < maxVals.Length; i++)
            {
                int maxChar = arr[i][0];
                for (int k = 0; k < arr[i].Length; k++)
                {
                    if (arr[i][k] > maxChar)
                        maxChar = arr[i][k];
                }
                maxVals[i] = maxChar;
            }

            Console.Write("\nСтаршие элементы каждой строки: ");
            foreach (int ch in maxVals)
            {
                Console.Write($"{ch} ");
            }
            Console.WriteLine();

            //Смена местами старших и первых элементов массива
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i][Array.IndexOf(arr[i], maxVals[i])] = arr[i][0];
                arr[i][0] = maxVals[i];
            }

            Console.WriteLine("\nОбновлённый массив");
            foreach (int[] row in arr)
            {
                foreach (int ch in row)
                {
                    Console.Write($"{ch} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
