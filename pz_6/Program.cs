using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            while (b < 10)
            {
                b++;
                Console.WriteLine($"{a * b} = {a} * {b}");
            }
        }
    }
}
