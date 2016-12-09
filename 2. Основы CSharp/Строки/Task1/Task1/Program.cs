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
        {//среднне значение = сумму букв во всех словах поделить на количество слов
            Console.CursorVisible = false;
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int sum = 0;
            str = str + ' '; //прибавили в конец пробел, чтобы не потерять последнее слово
            int aver = 0;
            char[] length = str.ToCharArray();
            int symbol = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if ((length[i] == ' '))
                {
                    sum += 1;
                    symbol -= 1;
                }
                else if ((length[i] == ','))
                {
                    sum += 1;
                    symbol -= 2;
                    i++;
                }
            }
            aver = symbol / sum;
            Console.WriteLine("Количество слов = {0} среднее значение = {1} количество букв = {2}", sum, aver, symbol);
            Console.ReadKey();
        }
    }
}


