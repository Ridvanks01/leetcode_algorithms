using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011.Final_Value_of_Variable_After_Performing_Operations
{
    internal class Program
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            foreach (string op in operations) {
                
                if(op == "++X" ||  op == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            return x;
        }
    }
}
