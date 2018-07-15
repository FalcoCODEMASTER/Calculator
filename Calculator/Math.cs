using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Math
    {
        public int Result;

        public int Plus(int NumberOne, int NumberTwo)
        {
            Result = NumberOne + NumberTwo;
            return Result;
        }

        public int Minus(int NumberOne, int NumberTwo)
        {
            Result = NumberOne - NumberTwo;
            return Result;

        }
        public int Divide(int NumberOne, int NumberTwo)
        {
            Result = NumberOne / NumberTwo;
            return Result;
        }
        public int Multiply(int NumberOne, int NumberTwo)
        {
            Result = NumberOne * NumberTwo;
            return Result;
        }

    }
}
