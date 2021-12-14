using System;

namespace pz_18
{
    class Program
    {
        static double Arifmeticheskaya(int n, double a, double d)
        {
            if (n < 1) return 0;
            else if (n == 1) return a;
            return Arifmeticheskaya(n - 1, a, d) + d;
        }
        static double Geometricheskaya(int n, double b, double q)
        {
            if (n == 1) return b;
            else return Geometricheskaya(n - 1, b, q) * q;
        }
        static void Vozrastanie(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b) return;
            Vozrastanie(b > a ? a + 1 : a - 1, b);
        }
        static void Reverse(int number)
        {
            int newNum = number % 10;
            Console.Write(newNum);
            number /= 10;

            if (number > 0)
                Reverse(number);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int d = 3;
            int a = 50;
            Console.Write("Введите количество шагов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Arifmeticheskaya(n, a, d);
            Console.WriteLine($"Вывод:{r}");

            Console.WriteLine("\nЗадание 2");
            double q = 4;
            double b = 8;
            Console.Write("Введите количество шагов: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double geom = Geometricheskaya(num, b, q);
            Console.WriteLine($"Вывод:{geom}");

            Console.WriteLine("\nЗадание 3");
            Vozrastanie(6, 45);

            Console.WriteLine("\nЗадание 4");
            Console.Write("Введите число для переворота: ");
            int rev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вывод: ");
            Reverse(rev);
            Console.ReadKey();
        }
    }
}
