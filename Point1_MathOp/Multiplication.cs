using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1_MathOp
{
    class Multiplication: Operation
    {
        double times;
        public Multiplication(double numberOne, double numberTwo) : base(numberOne, numberTwo)
        {
        }

        public override double Result
        {
            get { return times; }
        }

        public override void DoOperation(double n1, double n2)
        {
            times = n1 * n2;
        }
    }
}

