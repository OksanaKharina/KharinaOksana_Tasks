using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы в массив");
            string str = Console.ReadLine();
            string[] massiv = str.Split(' ');
            for (int i = 0; i < massiv.Length; i++)
            {
                arr[i] = Convert.ToInt32(massiv[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            Console.WriteLine("arr[{0}] = {1}", i, arr[i]);

            int sum = arr.Sum();
            Console.WriteLine("Сумма в массиве равна {0}", sum);
            Console.ReadKey();
        }
    }
}
