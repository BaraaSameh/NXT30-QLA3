using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    static class IntExtensions
    {
        public static bool IsEven(this int n) => n % 2 == 0;
        public static bool IsOdd(this int n) => n % 2 != 0;
        public static bool IsPrime(this int n) => n > 1 && Enumerable.Range(2, n - 2).All(i => n % i != 0);
        public static string ToRoman(this int num) { /* Roman logic here */ return "Roman"; }
        public static long Factorial(this int n) => n <= 1 ? 1 : n * Factorial(n - 1);
    }

}
