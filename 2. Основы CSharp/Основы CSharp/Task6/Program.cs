using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string MyStyle = "None";


            Console.WriteLine("Параметры надписи: {0}", MyStyle);


            Console.WriteLine("Введите: \n ");
            Console.WriteLine("     1: bold \n ");
            Console.WriteLine("     2: italic \n ");
            Console.WriteLine("     3: underline \n ");

            MyStyle = Console.ReadLine(); //считал

            Console.Write("Параметры надписи: ");
            TextStyle(MyStyle);//вывел
            
            Console.ReadKey();
        }
        static void TextStyle(string s)
        {

            switch (s)
            {
                case "1":
                    Console.WriteLine("bold \t");
                    break;

                case "2":
                    Console.WriteLine("italic \t");
                    break;

                case "3":
                    Console.WriteLine("underline \t");
                    break;
            }
        }
    }
}


