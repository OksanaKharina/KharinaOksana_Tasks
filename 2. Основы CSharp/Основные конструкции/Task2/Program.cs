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
            int n;
            Console.Write("Введите число элементов в трехмерном массиве \n");
            n = int.Parse(Console.ReadLine());
            int[, ,] arr = new int[n, n, n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; j < n; j++)
                    {
                        arr[i, j, k] = r.Next(-100, 100);//todo вот здесь можно было всё разом написать, чтобы 4 раза не бегать по массиву (т.е. создать 2 массива, один исходный, второй для нулей)
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; j < n; j++)
                    {
                        Console.WriteLine("arr[{0}, {1}, {2}] = {3} \n", i, j, k, arr[i, j, k]);//todo вот это
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; j < n; j++)
                    {
                        if (arr[i, j, k] < 0)//todo вот это
                            arr[i, j, k] = 0;//todo вот это
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; j < n; j++)
                    {
                        Console.WriteLine("arr[{0}, {1}, {2}] = {3} \n", i, j, k, arr[i, j, k]);//todo вот это
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


