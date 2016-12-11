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
            int ok = 0;
            while (ok == 0)
            {
                Console.Write("Введите внутренний радиус кольца r = ");
                try
                {
                    Ring ring = new Ring();
                    ring.r = Convert.ToInt16(Console.ReadLine());
                    Console.Write("\n Введите внешний радиус кольца R = ");
                    ring.R = Convert.ToInt16(Console.ReadLine());
                    if (ring.r > 0 && ring.R > 0 && ring.r < ring.R)
                    {
                        ok = ring.r;
                        var area = ring.Area(ring.R) - ring.Area(ring.r);
                        var sum = ring.Lenght(ring.R) + ring.Lenght(ring.r);
                        ring.writeRing((int)area, (int)sum);
                    }
                    else Console.WriteLine("Error r < = 0 or R < = 0 or r > R");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

