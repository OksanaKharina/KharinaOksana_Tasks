using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    //объявление класса, унаследованный от класса Circle
    public class Round : Circle
    {
        public double ComArea()
        {
            return Math.PI * r * r;
        }
    }
}