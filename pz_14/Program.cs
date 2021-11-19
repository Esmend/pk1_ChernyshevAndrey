using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Esmend\OneDrive\Рабочий стол\pz_14\pz14.txt";
            int s = 0;
            string str = "";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    while (true)
                    {
                        string a = Console.ReadLine();
                        str += a;
                        for (int i = 0; i<a.Length; i++ )
                        {
                            if (Char.IsDigit(a[i]))
                             s++;
                        }
                        if (a == string.Empty) 
                            break;
                        writer.WriteLine(a);

                    }

                }
            }
            Console.WriteLine($"Ваш текст:{str}");
            Console.WriteLine($"Количество чисел:{s}");
        }
    }
}
