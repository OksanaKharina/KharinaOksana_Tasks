using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Task3
{
    class Program
    {
        const int n = 100;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string str = "";
            Stopwatch sw = new Stopwatch();
            StringBuilder sb = new StringBuilder();

            sw.Start();

            string st = new string('*', n);
            Console.WriteLine("скорость работы класса string без цикла= {0}", sw.ElapsedTicks);//todo он в кишочках всё равно в цикле пробегается :) 

            sw.Restart();

            for (int i = 0; i < n; i++)
            {
                str += "*";
            }
            Console.WriteLine("скорость работы класса string в цикле= {0}", sw.ElapsedTicks);

            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine("скорость работы класса stringbuilder = {0}", sw.ElapsedTicks);

            sw.Stop();
            Console.ReadKey();
        }
    }
}

