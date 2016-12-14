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
        {//вычисление площади прямоугольника
            Console.CursorVisible = false;
            int s = 0;
            while (s == 0)
            {
                Console.WriteLine("Введите числа a и b, чтобы вычислить прямоугольник. a и b > 0 !!!");//todo некорректное сообщение. Либо проси "введите а", "введите б", либо пиши "введите а, нажмите "ввод", и введите б, нажмите "ввод""
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a > 0 && b > 0)
                    {
                        s = a * b;
                        Console.WriteLine("Площадь прямоугольника со сторонами a = {0}, b = {1}, равна s = {2}", a, b, s);
                    }
                    else Console.WriteLine("a и b < = 0. Попробуйте еще раз.");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

