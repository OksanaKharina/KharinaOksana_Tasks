using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Triangle //не вижу ни одной проверки корректности пришедших извне параметров
    {
        public double a;
        public double b;
        public double c;
        public double Area()
        {
            Console.WriteLine("Вычислим периметр и площадь треугольника \n Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                double Per = ((a + b + c) / 2);
                return Math.Sqrt(Per * (Per - a) * (Per - b) * (Per - c));
            }
            else return 0;
        }
        public double Perimeter()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                return a + b + c;
            }
            else return 0;
        }
    }
}

