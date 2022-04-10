using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point1_MathOp
{
    class Division: Operation
    {
        double div;
        public Division(double numberOne, double numberTwo) : base(numberOne, numberTwo)
        {
        }

        public override double Result
        {
            get { return div; }
        }

        public override void DoOperation(double n1, double n2)
        {
            div = n1 / n2;
        }
    }
}

