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
        {
            float x, y;
            Console.CursorVisible = false; // чтобы не было мигающего курсора
            string str, ok;
            ok = "y";
            while (ok == "y" || ok == "н")
            {
                Console.WriteLine("Введите координаты точки x, y");
                Console.WriteLine("x = ");
                x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("y = ");
                y = Convert.ToSingle(Console.ReadLine());
                while (ok == "y" || ok == "н")
                {
                    Console.WriteLine("Выберите график, для которого Вы хотите определить принадлежность точки: \n а, б, в, г, д, е, ж, з, и, к \n");
                    str = Console.ReadLine();
                    switch (str)
                    {
                        case "а": //окружность 1
                            MyMathOperation newACircle = new MyMathOperation();
                            newACircle.ACircleOne();
                            ok = "";
                            break;

                        case "б": //окружность 2
                            MyMathOperation newCircle = new MyMathOperation();
                            newCircle.BCircleTwo();
                            ok = "";
                            break;

                        case "в": //квадрат
                            Console.WriteLine(x <= 1 && x >= -1 && y <= 1 && y >= -1 ? "Принадлежит \n" : "Не принадлежит \n");
                            ok = "";
                            break;

                        case "г": //правильный ромб
                            Console.WriteLine((Math.Abs(x + y) <= 1 && Math.Abs(x - y) <= 1) ? "Принадлежит \n" : "Не принадлежит \n");
                            ok = "";
                            break;

                        case "д": //ромб
                            MyMathOperation newRhomb = new MyMathOperation();
                            newRhomb.Rhomb();
                            ok = "";
                            break;

                        case "е"://треугольник и полуокружность
                            MyMathOperation newTriCir = new MyMathOperation();
                            newTriCir.TriCir();
                            ok = "";
                            break;

                        case "ж"://треугольник
                            MyMathOperation newTriangle = new MyMathOperation();
                            newTriangle.Triangle();
                            ok = "";
                            break;

                        case "з"://2 треугольника и прямоугольник. Рассмотрена модуль функции
                            Console.WriteLine(x >= -1 && x <= 1 && y >= -2 && y <= 1 && y <= Math.Abs(x) ? "Принадлежит \n" : "Не принадлежит \n");
                            ok = "";
                            break;

                        case "и"://многоугольник
                            MyMathOperation newPolygon = new MyMathOperation();
                            newPolygon.Polygon();
                            ok = "";
                            break;

                        case "к"://бесконечная плоскость
                            MyMathOperation newInfPlane = new MyMathOperation();
                            newInfPlane.InfPlane();
                            ok = "";
                            break;

                        default:
                            Console.WriteLine("Ошибка! Необходимо вводить: а, б, в, г, д, е, ж, з, и или к. \n");
                            ok = "y";
                            break;
                    }
                }
                Console.WriteLine("Хотите продолжить: y?");
                ok = Convert.ToString(Console.ReadLine());

            }

        }
    }
}
