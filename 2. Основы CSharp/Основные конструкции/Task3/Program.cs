using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int n;
            Console.Write("Введите число элементов в массиве \n");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 0)
                    sum += arr[i];
            }
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.Write("Сумма неотрицательных элементов в массиве \n sum = {0} ", sum);
            Console.ReadKey();
        }
    }
}

