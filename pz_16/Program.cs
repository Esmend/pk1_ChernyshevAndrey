using System;

namespace pz_16
{
    class Program
    {
        public static int Quarter(int x, int y)
        {
            int result = 0;

            if (x > 0)
            {
                if (y > 0)
                    result = 1;
                else if (y < 0)
                    result = 4;
            }
            else 
            {
                if (y > 0)
                    result = 2;
                else if (y < 0)
                    result = 3;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = Quarter(x, y);
            Console.Write("Ваша четверть: ");
            Console.WriteLine(c);
        }
    }
}
