using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class SumArray
    {
        public static int Sum(this int[] arr, int n, int sum)
        {
            sum = 0;
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
    }
}
