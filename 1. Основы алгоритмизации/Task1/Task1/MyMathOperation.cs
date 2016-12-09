using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyMathOperation
    {
        enum Vars
        {
            x, y, x1, x2, x3, y1, y2, y3
        }
        //окружность "а"
        public float ACircleOne()
        {
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            Console.WriteLine((x * x + y * y <= 1) && (Math.Abs(x) <= 1 && Math.Abs(y) <= 1) ? "Принадлежит" : "Не принадлежит");
            return 0;
        }
        //окружность "б"
        public float BCircleTwo()
        {
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            if ((x * x + y * y <= 1) && (x <= 1 && x >= -1 && y <= 1 && y >= -1))
            {
                if ((x * x + y * y >= 0.25) && (x >= 0.5 || x <= -0.5 && y >= 0.5 || y <= -0.5))
                {
                    Console.WriteLine("Принадлежит");
                }
                else
                {

                    Console.WriteLine("Не принадлежит");
                }
            }
            return 0;
        }

        //ромб "д"
        public float Rhomb()
        {
            //Разобьем на два треугольника и проверим принадлежность точки каждому из них

            float x = (float)Vars.x;
            float y = (float)Vars.y;
            float x1 = (float)Vars.x1;
            float y1 = (float)Vars.y1;
            float x2 = (float)Vars.x2;
            float y2 = (float)Vars.y2;
            float x3 = (float)Vars.x3;
            float y3 = (float)Vars.y3;
            x1 = -0.5f; x2 = 0; x3 = 0.5f;
            y1 = 0; y2 = 1; y3 = 0;
            if ((x - x1) * (y1 - y2) - (y - y1) * (x1 - x2) >= 0 &&
                (x - x2) * (y2 - y3) - (y - y2) * (x2 - x3) >= 0 &&
                    (x - x3) * (y3 - y1) - (y - y3) * (x3 - x1) >= 0)
                Console.WriteLine("Принадлежит");
            else if (
                x1 == -0.5f && x2 == 0.5f && x3 == 0 &&
                y1 == 0 && y2 == 0 && y3 == -1 &&
                (x - x1) * (y1 - y2) - (y - y1) * (x1 - x2) >= 0 &&
                (x - x2) * (y2 - y3) - (y - y2) * (x2 - x3) >= 0 &&
                    (x - x3) * (y3 - y1) - (y - y3) * (x3 - x1) >= 0)
                Console.WriteLine("Принадлежит");

            else Console.WriteLine("Не принадлежит");
            return 0;
        }

        public float TriCir()
        {
            //треугольник и полуокружность

            //Разобьем на две фигруы треугольник и полуокружность и проверим принадлежность точки каждой из них

            //треуогольник
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            float t1, t2, t3, n1, n2, n3, a, b, c;
            t1 = 0; t2 = 0; t3 = -2;
            n1 = 1; n2 = -1; n3 = 0;
            a = (t1 - x) * (n2 - n1) - (t2 - t1) * (n1 - y);
            b = (t2 - x) * (n3 - n2) - (t3 - t2) * (n2 - y);
            c = (t3 - x) * (n1 - n3) - (t1 - t3) * (n3 - y);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                Console.WriteLine("Принадлежит");

            //полуокружность

            else if (x * x + y * y <= 1 && x <= 1 && x >= 0 && Math.Abs(y) <= 1)
                Console.WriteLine("Принадлежит");
            else
                Console.WriteLine("Не принадлежит");
            return 0;
        }

        public float Triangle()
        {
            //треугольник
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            float p1, p2, p3, q1, q2, q3, m, n, k;
            p1 = 0; p2 = 1.5f; p3 = -1.5f;
            q1 = 2; q2 = -1; q3 = -1;
            m = (p1 - x) * (q2 - q1) - (p2 - p1) * (q1 - y);
            n = (p2 - x) * (q3 - q2) - (p3 - p2) * (q2 - y);
            k = (p3 - x) * (q1 - q3) - (p1 - p3) * (q3 - y);
            Console.WriteLine((m >= 0 && n >= 0 && k >= 0) || (m <= 0 && n <= 0 && k <= 0) ? "Принадлежит \n" : "Не принадлежит \n");
            return 0;
        }
        public float Polygon()
        {
            //многоугольник
            //Разобьем на два треугольника и проверим принадлежность точки каждому из них
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            float s1, s2, s3, w1, w2, w3;
            s1 = -1; s2 = -1.5f; s3 = 0;
            w1 = 1; w2 = 0; w3 = 0;
            if ((x - s1) * (w1 - w2) - (y - w1) * (s1 - s2) >= 0 &&
                (x - s2) * (w2 - w3) - (y - w2) * (s2 - s3) >= 0 &&
                    (x - w3) * (w3 - w1) - (y - w3) * (s3 - s1) >= 0)
                Console.WriteLine("Принадлежит");
            else if (
                s1 == -1.5f && s2 == 1 && s3 == -2 &&
                w1 == 0 && w2 == 0 && w3 == -2 &&
                (x - s1) * (w1 - w2) - (y - w1) * (s1 - s2) >= 0 &&
                (x - s2) * (w2 - w3) - (y - w2) * (s2 - s3) >= 0 &&
                    (x - s3) * (w3 - w1) - (y - w3) * (s3 - s1) >= 0)
                Console.WriteLine("Принадлежит");

            else Console.WriteLine("Не принадлежит");
            return 0;
        }
        public float InfPlane()
        {
            //бесконечная плоскость
            float x = (float)Vars.x;
            float y = (float)Vars.y;
            if (x >= -1 && x <= 1 && y > 0 && y >= Math.Abs(x))
                Console.WriteLine("Принадлежит");
            else if (x >= 1 && x <= -1 && y >= 1)
                Console.WriteLine("принадлежит");
            else
                Console.WriteLine("Не принадлежит");
            return 0;
        }
    }

}
