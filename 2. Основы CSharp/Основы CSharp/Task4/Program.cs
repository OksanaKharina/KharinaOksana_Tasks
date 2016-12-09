using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Write("Введите количество треугольников N = ");
            string str = Console.ReadLine();
            int h = int.Parse(str) + 1;
            int k = h * 2;
            char[,] arr = new char[h, k];

            //left
            int n = 0;
            while (n < h)
            {
                n++;
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        arr[i, j] = ' ';
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = k / 2 - i; j < h + 1; j++)
                    {
                        arr[i, j] = '*';
                    }
                }
                //right
                for (int i = 0; i < n; i++)
                {
                    for (int j = h + 1; j < k / 2 + 1 + i; j++)
                    {
                        arr[i, j] = '*';
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write(arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}


