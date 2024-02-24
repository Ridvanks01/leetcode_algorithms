using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _771.Jewels_and_Stones
{
    internal class Program
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            char[] jewelsArray = new char[1];
            jewelsArray = jewels.ToCharArray();

            char[] stonesArray = new char[1];
            stonesArray = stones.ToCharArray();

            int counter = 0;

            for (int i = 0; i < jewelsArray.Length; i++)
            {
                for (int j = 0; j < stonesArray.Length; j++)
                {
                    if (jewelsArray[i] == stonesArray[j])
                        counter++;
                }
            }

            return counter;
        }
    }
}
