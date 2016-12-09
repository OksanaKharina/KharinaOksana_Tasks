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
            Console.Write("N = ");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            char[,] arr = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arr[i, j] = '*';
                    Console.Write(arr[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
