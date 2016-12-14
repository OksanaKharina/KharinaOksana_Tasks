using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
      class Program//todo было же уже это задание в папке task1
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int ok = 0;
            while (ok == 0)
            {
                Console.Write("Введите радиус окружности R = ");
                try
                {
                    // Создадим объект типа Round
                    Round round = new Round();
                    round.r = Convert.ToInt16(Console.ReadLine());
                    if (round.r > 0)
                    {
                        ok = round.r;
                        var length = round.ComLength();
                        var area = round.ComArea();
                        Circle wrRound = new Circle();
                        wrRound.writeRound((int)length, (int)area);
                    }
                    else Console.WriteLine("Error. R < = 0");
                }
                catch (FormatException)
                { Console.WriteLine("Error."); }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

