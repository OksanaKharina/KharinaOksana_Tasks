using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class User
    {
        public string Surname, Name, MiddleName, DateOfBirth; //todo вот так вот писать вообще не стоит - одно поле - одна строка. Использовать свойства вместо полей. DateOfBirth должна быть типа DateTime.
        public byte Age; //todo должен быть вычисляем относительно даты рождения.
        public void writeUser(string S, string N, string M, string D, byte A)
        {
            Console.WriteLine("Фамилия: {0} \nИмя: {1} \nОтчество: {2} \nДата рождения: {3} \nВозраст: {4}", S, N, M, D, A);
        }
    }
}
