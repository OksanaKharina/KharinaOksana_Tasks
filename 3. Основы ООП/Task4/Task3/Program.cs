using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string ok = "y";
            while (ok == "y" || ok == "н")
            {
                Console.Clear();
                while (ok == "y" || ok == "н")
                {
                    User Date = new User();
                    Console.WriteLine("Введите фамилию");
                    Date.Surname = Console.ReadLine();
                    Console.WriteLine("Введите имя");
                    Date.Name = Console.ReadLine();
                    Console.WriteLine("Введите Отчество");
                    Date.MiddleName = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения");
                    Date.DateOfBirth = Console.ReadLine();
                    Console.WriteLine("Введите возраст");
                    Date.Age = Convert.ToByte(Console.ReadLine());

                    Date.writeUser(Date.Surname, Date.Name, Date.MiddleName, Date.DateOfBirth, Date.Age);
                    ok = " ";
                }
                Console.WriteLine("Хотите ввести данные о пользователе: y(н)?");
                ok = Console.ReadLine();
            }
        }
    }
}

