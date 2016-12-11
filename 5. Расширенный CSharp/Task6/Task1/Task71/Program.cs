using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           // numbers.Add(6); // добавление элемента
           // numbers.AddRange(new int[] { 7, 8, 9 });
         //   numbers.Insert(0, 666); // вставляем на первое место в списке число 666
          //  numbers.RemoveAt(1); //  удаляем второй элемент
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }

            int j = 0;
            while (numbers.Count != 1)
            {
                Console.WriteLine(" n = " + numbers.Count);
                for (j = 0; j < numbers.Count; j++)
                {

                    if (j % 2 != 0)
                      //  continue;
                    numbers.RemoveAt(j);

                }
                Console.WriteLine();
                // numbers.Reverse();
                foreach (int i in numbers)
                {
                    Console.Write(" " + i);
                }
                //double k = j / 2;
                //j = (int)Math.Ceiling(k);
                double k = numbers.Count / 2;
                j = (int)Math.Ceiling(k);
                //j = numbers.Count / 2;
                // numbers.Reverse();
            }
            Console.ReadLine();
        }
    }
}
