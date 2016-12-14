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

            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            string ok = str.Rez();
            Console.WriteLine(ok);
            Console.ReadKey();
        }
    }
}
