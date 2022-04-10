using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1_MathOp
{
    abstract class Operation
    {
        double numberOne, numberTwo;

        public Operation(double numberOne, double numberTwo)
        {
            this.numberOne = numberOne;
            this.numberTwo = numberTwo;
        }

        public abstract double Result { get;}

        public abstract void DoOperation(double n1, double n2);
    }
}
