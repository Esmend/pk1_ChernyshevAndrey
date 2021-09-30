using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            {             
                for (int a = 20; a <= 90; a += 5)
                {
                    Console.WriteLine(a);
                }
            }
            Console.WriteLine("Задание 2");
            {
                string[] a = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", };
                for (int b = 7; b <= 11; b++) Console.Write(a[b]);
            }
            Console.WriteLine("\nЗадание 3");
            {
                for (int i = 1; i <= 8; i++)
                {
                    for (int k = 1; k <= 7; k++) Console.Write("#");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Задание 4");
            {
                for (int u = 0; u <= 100; u++) if (u % 13 == 0) Console.Write(" " + u);
            }
        }
    }
}
