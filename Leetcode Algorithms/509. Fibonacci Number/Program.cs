using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509.Fibonacci_Number
{
    internal class Program
    {
        public int Fib(int n)
        {
            if(n == 0) return 0;
            if(n == 1 || n == 2) return 1;

            int num1 = 1;
            int num2 = 1;

            for(int i = 2; i < n - 1; i++) {

                int temp = num2;
                num2 = num1 + num2;
                num1 = temp;
            }

            return num1 + num2;
        }
    }
}
