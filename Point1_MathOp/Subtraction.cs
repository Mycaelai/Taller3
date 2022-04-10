using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1_MathOp
{
    class Subtraction: Operation
    {
        double sub;
        public Subtraction(double numberOne, double numberTwo) : base(numberOne, numberTwo)
        {
        }

        public override double Result
        {
            get { return sub; }
        }

        public override void DoOperation(double n1, double n2)
        {
            sub = n1 - n2;
        }
    }
}

