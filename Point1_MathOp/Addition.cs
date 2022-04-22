using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1_MathOp
{
    class Addition : Operation
    {
        double sum;
        public Addition(double numberOne, double numberTwo) : base(numberOne, numberTwo)
        {
        }

        public override double Result
        {
            get {   return sum; }
        }
        

        public override void DoOperation(double n1, double n2)
        {
            sum = n1 + n2;
        }
    }
}
