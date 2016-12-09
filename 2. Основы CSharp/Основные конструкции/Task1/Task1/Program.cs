using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int n;
            Console.Write("Введите число элементов массива: n = ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];
                if (min > arr[i]) min = arr[i];
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int sor = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = sor;
                }
            }
            Console.Write("\n max = {0}, min = {1} \n", max, min);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = {1} \n", i, arr[i]);
            }
            Console.ReadKey();
        }
    }
}

