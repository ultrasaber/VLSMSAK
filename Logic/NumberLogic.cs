using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class NumberLogic
    {
        public const int BINARY_NUMBER_LENGTH = 8;

        public static string IntToBinary(int n)
        {
            char[] b = new char[BINARY_NUMBER_LENGTH];
            int pos = BINARY_NUMBER_LENGTH - 1;
            int i = 0;

            while (i < BINARY_NUMBER_LENGTH)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
