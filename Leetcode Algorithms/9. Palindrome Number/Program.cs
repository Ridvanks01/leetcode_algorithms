using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    internal class Program
    {
        public bool IsPalindrome(int x)
        {
            string stringX = Convert.ToString(x);

            string xRev = new string(stringX.Reverse().ToArray());

            if(xRev == stringX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
