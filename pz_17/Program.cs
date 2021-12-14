using System;
using System.IO;

namespace pz_17
{
    class Program
    {
        static string Papka(string a)
        {        
            
            
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(a);
                foreach (string b in dirs)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(a);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Путь к файлу: ");
            string n = Console.ReadLine();
            string m = Papka(n);
            Console.WriteLine(m);
        }
    }
}
