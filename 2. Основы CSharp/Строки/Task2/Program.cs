using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Write("Введите первую строку str1: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите слово:");
            string str2 = Console.ReadLine();

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(a[i]);
                for (int j = 0; j < str2.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.Write(b[j]);
                        j = str2.Length;
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
