using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle
    { //Поля класса
        public int x;
        public int y;
        public int r;
        //метод
        public double ComLength()
        {
            return 2 * Math.PI * r;
        }
        public void writeRound(int len, int are)
        {
            Console.WriteLine("Длина окружности l = {0}, площадь круга S = {1}", len, are);
        }
    }
}