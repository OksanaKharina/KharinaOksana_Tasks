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
            int n;
            Console.Write("Введите число элементов в массиве \n");
            n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                    Console.Write("{0} \t", arr[i, j]);
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 != 0)
                        continue;
                    sum += arr[i, j];
                }
            }
            Console.WriteLine();
            Console.Write("Сумма элементов в массиве, стоящих на четных позициях \n sum = {0} ", sum);
            Console.ReadKey();
        }
    }
}


