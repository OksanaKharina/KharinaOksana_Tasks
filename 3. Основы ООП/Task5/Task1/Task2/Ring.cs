using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ring//todo каким образом обеспечиваешь нахождение класса в заведомо корректном состоянии (где хоть одна проверка полей класса на корректные значения)? 
    {
        public int x;
        public int y;
        public int r;
        public double Area(int r)
        {
            return Math.PI * r * r;
        }
        public double Lenght(int r)
        {
            return 2 * Math.PI * r;
        }
        public void writeRing(int area, int sum)
        {
            Console.WriteLine("Площадь кольца S = {0}, сумма длин длин внешнего и внутреннего радиусов sum = {1}", area, sum);
        }

        public short R { get; set; }
    }
}
