using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Math.BasicOp;

namespace Exercicios.Math
{
    public class Operations
    {
        public Summation Sum { get; private set; }
        public Subtraction Sub { get; private set; }
        public Multiplication Dot { get; private set; }
        public Division Div { get; private set; }

        public Operations()
        {
            this.Sum = new Summation();
            this.Sub = new Subtraction();
            this.Dot = new Multiplication();
            this.Div = new Division();
        }
    }

}
