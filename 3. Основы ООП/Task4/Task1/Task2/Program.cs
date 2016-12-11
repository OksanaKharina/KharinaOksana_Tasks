using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   
        class Program
        {
            static void Main()
            {

                Console.CursorVisible = false;
                Triangle rez = new Triangle();
                if (rez.Area() != 0 && rez.Perimeter() != 0)
                {
                    Console.WriteLine("Площадь равна " + rez.Area());

                    Console.WriteLine("Периметр равен " + rez.Perimeter());
                }
                else Console.WriteLine("Error");


                Console.ReadLine();
            }
        }
    }
